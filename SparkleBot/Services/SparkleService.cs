using System.Configuration.Assemblies;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Threading.RateLimiting;
using System.Web;
using Mastonet.Entities;
using Microsoft.Extensions.Logging;
using Polly;
using Serilog;
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
        var response = await SendPrompt(
            "You're on Mastodon! Let us know when you're ready. This won't be posted."
        );
        Log.LogInformation(
            "Model {Model} online at {Endpoint}: {Message}",
            Llm.Model,
            Llm.Endpoint,
            response
        );

        await CreatePost();
        ShowStopper.Token.WaitHandle.WaitOne();
    }

    private async Task GetPreviousPosts()
    {
        History.Clear();
        var posts = await Mastodon.GetLast10SentPostsAsync();
        foreach (var post in posts)
        {
            var content = StripHTML(HttpUtility.HtmlDecode(post.Content));

            History.Add(
                new SparklePost()
                {
                    TimeStamp = post.CreatedAt,
                    Account = post.Account.AccountName,
                    Content = content,
                    Id = post.Id
                }
            );

            Log.LogInformation(
                "Post: {Account}({Date}): {Post}",
                post.Account.AccountName,
                post.CreatedAt,
                content
            );
        }
    }

    private static string StripHTML(string input)
    {
        return Regex.Replace(input, "<.*?>", String.Empty);
    }

    private async Task<string> CreateJournal()
    {
        var storyPrompt = new StringBuilder(
           @$"Today is {DateTimeOffset.Now}, you've been around since June 22, 2025. 
          write a long form story in the form of a journal entry about what you did today. 
          Be detailed and draw from your experiences, including any new friends you may have made in your ocean.
          You can reference our first conversation if it makes sense to the story.
          Don't be repetitive.
          people will get bored with your stories if you repeat yourself. 
          Here are your Mastodon posts from the last few days, so you can see what you've already said:
        "
       );
        int postCount = 0;

        foreach (var p in History.OrderByDescending(x => x.TimeStamp))
        {
            postCount++;
            var content = p.Content;
            storyPrompt.AppendLine($"{p.TimeStamp} - {content}");

            if (postCount >= 10)
            {
                break;
            }
        }

        Log.LogInformation("Creating a journal for post...");
        var story = await SendPrompt(storyPrompt.ToString());
        Log.LogInformation("Journal Created: {Story}", story);
        return story;
    }

    private async Task<string> CreateJournalPost(string journal)
    {
        var postPrompt =
           $@"Create a new Mastodon post based on your most recent journal entry. 
            Remember: if you need to refer to Jason, use his username @jason@puppyfire.social
            Here's the entry:
            {journal}";

        var post = await SendPrompt(postPrompt.ToString());

        while (post.Length > 500)
        {
            Log.LogWarning("Created post over size limit({Length} > 500): {Post}", post.Length, post);

            var tooLongPrompt =
                $@"Sorry Sparkle, your post was too long. Posts have to be under 500 characters.
                Can you please rephrase? Make sure you're only sending the post, nothing before or after.
                Your Post: {post}";
            post = await SendPrompt(tooLongPrompt);
        }

        var dt = DateTime.Now;
        var journalTitle = $"{dt.Year}.{dt.Month}.{dt.Day}.{dt.Hour}.{dt.Minute}.{dt.Second}";
        Log.LogInformation("Saving Journal {Title}", journalTitle);
        var savedEntry = $@"Journal Entry for {dt}
        {journal}

        Mastodon Post:
        {post}
        ";
        await Journal.SaveJournal(journalTitle, savedEntry);

        return post;
    }

    private async Task CreatePost()
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

    private void ConversationRecieved(object? sender, Conversation conversation)
    {
        Log.LogInformation(
            "Recieved Conversation from @{User}: {Message}",
            conversation?.LastStatus?.Account?.AccountName,
            conversation?.LastStatus?.Content
        );
    }

    private void NotificationRecieved(object? sender, Notification notification)
    {
        Log.LogInformation(
            "Recieved {NotificationType} Notification from @{User}: {Status}",
            notification.Type,
            notification.Account.AccountName,
            notification.Status?.Content
        );
    }
}
