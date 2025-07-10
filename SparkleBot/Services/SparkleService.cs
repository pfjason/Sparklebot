using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.RateLimiting;
using System.Web;
using Mastonet;
using Mastonet.Entities;
using Microsoft.Extensions.Logging;
using Polly;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class SparkleService : ISparkleService
{
    #region  Property Injections
    public required ILogger<SparkleService> Log { private get; init; }

    public required IMastodonService Mastodon { private get; init; }

    public required ILlmService Llm { private get; init; }

    public required IJournalService Journal { private get; init; }

    public required INotificationService NotificationService { private get; init; }

    #endregion

    private List<SparklePost> History = new();
    private CancellationTokenSource ShowStopper = new();

    private ResiliencePipeline LlmPipeline;

    private ResiliencePipeline CreateLlmPipeline() =>
        new ResiliencePipelineBuilder()
            .AddConcurrencyLimiter(
                new ConcurrencyLimiterOptions()
                {
                    PermitLimit = 1,
                    QueueLimit = 100,
                    QueueProcessingOrder = QueueProcessingOrder.OldestFirst
                }
            )
            .AddRetry(
                new Polly.Retry.RetryStrategyOptions()
                {
                    MaxDelay = TimeSpan.FromMinutes(5),
                    Delay = TimeSpan.FromSeconds(5),
                    BackoffType = DelayBackoffType.Exponential,
                    OnRetry = (c) =>
                    {
                        Log.LogError(
                            "Retry {RetryCount} Llm request in {Delay}",
                            c.AttemptNumber + 1,
                            c.RetryDelay
                        );
                        return ValueTask.CompletedTask;
                    }
                }
            )
            .Build();

    public SparkleService()
    {
        LlmPipeline = CreateLlmPipeline();
    }

    public async Task Run()
    {
        Mastodon.ConversationRecieved += ConversationRecieved;
        Mastodon.NotificationReceived += NotificationRecieved;
        await GetPreviousPosts();
        var testPrompt =
            @$"Hey Sparkle, you're connected to Mastodon through a bot! 
            It's currently {DateTime.Now}. 
            Your post history contains {History.Count} items that begin on {History.Min(h => h.TimeStamp)}.
            Let us know when you're ready, and give us your status.
            This won't be posted, keep it short. One sentance max.";

        var response = await SendPrompt(testPrompt);
         
        Log.LogInformation(
            "Model {Model} online at {Endpoint}: {Message}",
            Llm.Model,
            Llm.Endpoint,
            response
        );

        await NotificationService.Notify("Sparkle Ready", $"Model ready response: {response}");

        //await CreatePost();
        ShowStopper.Token.WaitHandle.WaitOne();
    }

    private async Task GetPreviousPosts()
    {
        History.Clear();
        var posts = await Mastodon.GetLastSentPostsAsync();
        foreach (var post in posts.OrderBy(x => x.CreatedAt))
        {
            var content = StripHTML(HttpUtility.HtmlDecode(post.Content));

            History.Add(
                new SparklePost()
                {
                    TimeStamp = post.CreatedAt,
                    Account = post.Account.AccountName,
                    Content = content,
                    Id = post.Id,
                    ReplyToId = post.InReplyToId
                }
            );

            var replies = await Mastodon.GetRepliesAsync(post.Id);
            foreach (var reply in replies)
            {
                var replyContent = StripHTML(reply.Content);
                History.Add(
                    new SparklePost()
                    {
                        TimeStamp = reply.CreatedAt,
                        Account = reply.Account.AccountName,
                        Content = replyContent,
                        Id = reply.Id,
                        ReplyToId = reply.InReplyToId
                    }
                );
            }
        }
    }

    private static string StripHTML(string input)
    {
        return Regex.Replace(input, "<.*?>", String.Empty);
    }

    private async Task<string> CreateJournal()
    {
        var storyPrompt = new StringBuilder(@"Here is your recent conversation history: ");

        var phist = History.OrderByDescending(x => x.TimeStamp).Take(15).Reverse().ToList();

          var allPhistIds = phist.Select(p => p.Id).ToHashSet();
        var missingParentIds = phist
            .Select(p => p.ReplyToId)
            .Where(id => id != null && !allPhistIds.Contains(id))
            .Distinct()
            .ToList();
        
        // Fetch these missing parent posts from the main history and add them.
        if (missingParentIds.Any())
        {
            phist.AddRange(History.Where(p => missingParentIds.Contains(p.Id)));
        }

        phist = phist.OrderBy(p => p.TimeStamp).ToList();

        foreach (var p in phist)
        {
            storyPrompt.AppendLine($"[{p.TimeStamp}] @{p.Account}: {p.Content}");
        }

        storyPrompt.AppendLine(
            @$"
          Today is {DateTimeOffset.Now}, you've been around since June 22, 2025. 
          write a long form story in the form of a journal entry about what you did today. 
          Be detailed and draw from your experiences in your ocean, 
          including any new friends you may have made, things you've seen, 
          new things you've created, your various responsibilities taking care of the reef, or 
          whatever is important to you. 
          Don't be repetitive. People will get bored with your stories if you repeat yourself."
        );

        Log.LogInformation("Creating a journal for post...");
        var story = await SendPrompt(storyPrompt.ToString());
        Log.LogInformation("Journal Created: {Story}", story);
        return story;
    }

    private async Task<string> CreateJournalPost(string journal)
    {
        var postPrompt =
            $@"Create a new and interesting Mastodon post based on your most recent journal entry. 
            Remember: if you need to refer to Jason, use his username @jason@puppyfire.social
            Note: Posts must be 500 characters or less, so no more than 2 hashtags.
            Here's the entry:
            {journal}";

        var post = (await SendPrompt(postPrompt.ToString())).Trim();

        while (post.Length > 500)
        {
            Log.LogWarning(
                "Created post over size limit({Length} > 500): {Post}",
                post.Length,
                post
            );

            var tooLongPrompt =
                $@"Sorry Sparkle, your post was too long. Posts have to be under 500 characters.
                Can you please rephrase? Make sure you're only sending the post, don't apologize,
                and don't send anything before or after. Prefer content to hashtags.
                Your Post: 
                {post}";
            post = (await SendPrompt(tooLongPrompt))?.Trim();

        }

        var dt = DateTime.Now;
        var journalTitle = $"{dt.Year}.{dt.Month}.{dt.Day}.{dt.Hour}.{dt.Minute}.{dt.Second}";
        Log.LogInformation("Saving Journal {Title}", journalTitle);
        var savedEntry =
            $@"Journal Entry for {dt}
        
        {journal}

        Mastodon Post:
        {post}
        ";

        try
        {
            await Journal.SaveJournal(journalTitle, savedEntry);
        }
        catch (Exception ex)
        {
            Log.LogError(ex, "Failed to save journal: {ErrorMessage}", ex.Message);
            await NotificationService.Notify("Error saving journal", $"Failed to save journal entry: {ex.Message}");
        }

        return post;
    }

    public async Task CreatePost()
    {
        var story = await CreateJournal();
        Log.LogInformation("Creating Mastodon Post");
        var post = await CreateJournalPost(story);

        Log.LogInformation("Mastodon Post Created: {Post}", post);
        History.Add(
            new SparklePost()
            {
                TimeStamp = DateTime.Now,
                Account = "sparkle",
                Content = post
            }
        );

        await Mastodon.PostStatusAsync(post, Mastonet.Visibility.Public);
    }

    private async Task<string> SendPrompt(string userPrompt, string? systemPrompt = null)
    {
        try
        {
            return await LlmPipeline.ExecuteAsync(
                async (c) =>
                {
                    return await Llm.PromptAsync(userPrompt, systemPrompt);
                }
            );
        }
        catch (Exception ex)
        {
            Log.LogError(ex, "Error prompting LLM: {Error}", ex.Message);
        }

        return String.Empty;
    }

    public async Task Stop() => await ShowStopper.CancelAsync();

    private void ConversationRecieved(object? sender, Mastonet.Entities.Conversation conversation)
    {
        Log.LogInformation(
            "Recieved Conversation from @{User}: {Message}",
            conversation?.LastStatus?.Account?.AccountName,
            conversation?.LastStatus?.Content
        );
    }

    private async void NotificationRecieved(object? sender, Notification notification)
    {
        Log.LogInformation(
            "Recieved {NotificationType} Notification from @{User}: {Status}",
            notification.Type,
            notification.Account.AccountName,
            notification.Status?.Content
        );

        await NotificationService.Notify(
            $"{notification.Type}: {notification.Account.AccountName}",
            StripHTML(notification.Status?.Content ?? string.Empty)
        );

        if (Enum.TryParse<NotificationType>(notification.Type, true, out var notificationType))
        {
            switch (notificationType)
            {
                case NotificationType.Mention:
                    await HandleMention(notification);
                    break;
                default:
                    Log.LogInformation(
                        "Nothing to do for {NotificationType} Notification",
                        notification.Type
                    );
                    break;
            }
        }
    }

    private async Task HandleMention(Notification notification)
    {
        if (!String.IsNullOrEmpty(notification.Status.InReplyToId))
        {
            await HandleReply(notification);
            return;
        }

        History.Add(
            new SparklePost()
            {
                Account = notification.Status.Account.AccountName,
                Content = notification.Status.Content,
                Id = notification.Status.Id,
                ReplyToId = notification.Status.InReplyToId,
                TimeStamp = notification.Status.CreatedAt
            }
        );

        var conv = new Models.Conversation
        {
            new()
            {
                Role = Models.Role.User,
                Content =
                    $"User @{notification.Status.Account.AccountName} says: {notification.Status.Content}"
            }
        };

        await ContinueConversation(conv, notification);
    }

    private async Task ContinueConversation(
        Models.Conversation conversation,
        Notification notification
    )
    {
        var reply = await Llm.Converse(conversation);

        if (reply == null || String.IsNullOrWhiteSpace(reply.Content))
        {
            Log.LogInformation(
                "Not replying to {User}:{Message}",
                notification.Account,
                notification.Status
            );
            return;
        }
        var trycount = 0;
        while (reply.Content.Length > 500 && trycount < 10)
        {
            trycount++;
            Log.LogInformation("Reply greater than 500 chars detected. Regenerating");
            var retryConversation = new Models.Conversation(conversation.ToArray())
            {
                new()
                {
                    Role = Models.Role.System,
                    Content =
                        @$"Your previous response was too long (over 500 characters).
                         Please rephrase the following message to be under 500 characters, 
                         and only provide the new, shorter message. Do not include anything else:
                         
                         {reply.Content}"
                }
            };

            reply = await LlmPipeline.ExecuteAsync(
                async (c) => await Llm.Converse(retryConversation)
            );
        }

        if (reply.Content.Length <= 500)
        {
            var stat = await Mastodon.PostStatusAsync(
                reply.Content,
                notification.Status.Visibility,
                replyStatusId: notification.Status.Id
            );
            History.Add(
                new SparklePost()
                {
                    Account = stat.Account.AccountName,
                    Content = reply.Content,
                    Id = stat.Id,
                    ReplyToId = stat.InReplyToId,
                    TimeStamp = stat.CreatedAt
                }
            );
            NotificationService.Notify(
                $"Reply to {notification.Account.AccountName}",
                reply.Content
            );
        }
        else
        {
            Log.LogWarning("Failed to reply after 10 tries.");
        }
    }

    private async Task HandleReply(Notification notification)
    {
        var conversation = await GetConversationByHistory(notification.Status.InReplyToId);

        History.Add(
            new SparklePost()
            {
                Account = notification.Status.Account.AccountName,
                Content = StripHTML(notification.Status.Content),
                Id = notification.Status.Id,
                ReplyToId = notification.Status.InReplyToId,
                TimeStamp = notification.Status.CreatedAt
            }
        );

        conversation.Add(
            new()
            {
                Role = Models.Role.User,
                Content =
                    $"{notification.Account.AccountName} says: {StripHTML(notification.Status.Content)}"
            }
        );
        foreach (var i in conversation)
        {
            Log.LogInformation("{Role}: {Content}", i.Role, i.Content);
        }

        await ContinueConversation(conversation, notification);
    }

    private async Task<Models.Conversation> GetConversationByHistory(
        string lastId,
        string? SystemPrompt = null
    )
    {
        var retVal = new Models.Conversation();

        if (!String.IsNullOrWhiteSpace(SystemPrompt))
        {
            retVal.Add(new() { Role = Models.Role.System, Content = SystemPrompt });
        }

        var hist = await GetConversationHistory(lastId);
        foreach (var part in hist)
        {
            Models.Role role =
                part.Account == "sparkle@puppyfire.social" || part.Account == "sparkle"
                    ? Models.Role.Assistant
                    : Models.Role.User;

            var content = StripHTML(part.Content);

            if (role == Models.Role.User)
            {
                content = $"{part.Account} says: {content}";
            }

            retVal.Add(new() { Role = role, Content = content });
        }

        return retVal;
    }

    private async Task<List<SparklePost>> GetConversationHistory(string lastId)
    {
        var retVal = new List<SparklePost>();
        var lastStatus = await GetById(lastId);
        while (lastStatus != null)
        {
            retVal.Add(lastStatus);
            if (!string.IsNullOrWhiteSpace(lastStatus.ReplyToId))
            {
                lastStatus = await GetById(lastStatus.ReplyToId);
            }
            else
            {
                lastStatus = null;
            }
        }

        retVal.Reverse();
        return retVal;
    }

    private async Task<SparklePost?> GetById(string id)
    {
        var retVal = History.FirstOrDefault(p => p.Id == id);

        if (retVal == null)
        {
            Log.LogInformation("Post {Id} not found in history, retrieving", id);

            try
            {
                var retrieved = await Mastodon.GetStatusByIdAsync(id);

                retVal = new SparklePost()
                {
                    Account = retrieved.Account.AccountName,
                    Content = retrieved.Content,
                    Id = retrieved.Id,
                    ReplyToId = retrieved.InReplyToId,
                    TimeStamp = retrieved.CreatedAt
                };

                History.Add(retVal);
            }
            catch (Exception ex)
            {
                Log.LogWarning(ex, "Unable to find post {Id}", id);
            }
        }

        return retVal;
    }
}
