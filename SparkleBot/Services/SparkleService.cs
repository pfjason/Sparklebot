using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.RateLimiting;
using System.Web;
using Mastonet;
using Mastonet.Entities;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Polly;
using SparkleBot.Enums;
using SparkleBot.Interfaces;
using SparkleBot.Models;
using Conversation = SparkleBot.Models.Conversation;
using Role = SparkleBot.Models.Role;

namespace SparkleBot.Services;

public class SparkleService : ISparkleService, IHostedService
{
    #region  Property Injections
    public required ILogger<SparkleService> Log { private get; init; }

    public required IMastodonService Mastodon { private get; init; }

    public required ILlmService Llm { private get; init; }

    public required IJournalService Journal { private get; init; }

    public required INotificationService NotificationService { private get; init; }

    public required IToolService ToolService { private get; init; }

    public required IMqttService Mqtt { private get; init; }

    #endregion

    public string ReadyMessage { get; private set; } = String.Empty;

    public List<SparklePost> History { get; private set; } = new();

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

    public async Task RunAndWait()
    {
        await Run();
        ShowStopper.Token.WaitHandle.WaitOne();
    }

    public async Task Run()
    {
        Mastodon.ConversationRecieved += ConversationRecieved;
        Mastodon.NotificationReceived += NotificationRecieved;
        Mqtt.MessageReceived += MqttReceived;
        await GetPreviousPosts();
        var testPrompt =
            @$"Bot says: Hey Sparkle, you're connected to Mastodon through the bot! 
            It's currently {DateTime.Now}. 
            Your post history contains {History.Count} items that begin on {History.Min(h => h.TimeStamp)}.
            Give us a good status message to let Jason know you're online.
            This won't be posted, but it will be displayed as the ready message
            on the bot's web interface, so keep it shortish and informative.";

        var response = await SendPrompt(testPrompt);

        Log.LogInformation(
            "Model {Model} online at {Endpoint}: {Message}",
            Llm.Model,
            Llm.Endpoint,
            response
        );

        await NotificationService.Notify("Sparkle Ready", $"{response}");

        ReadyMessage = response;
    }

    private void AddHistory(SparklePost post)
    {
        if (!History.Any(h => h.Id == post.Id))
        {
            History.Add(post);
        }
    }

    private async Task GetPreviousPosts()
    {
        History.Clear();
        var posts = await Mastodon.GetLastSentPostsAsync(1000);
        foreach (var post in posts.OrderBy(x => x.CreatedAt))
        {
            var content = StripHTML(HttpUtility.HtmlDecode(post.Content));

            AddHistory(
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

                AddHistory(
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

    public async IAsyncEnumerable<ConversationPart> ConverseWithModel(
        FriendModel model,
        bool sparkleFirst,
        bool save = false
    )
    {
        var firstModel = sparkleFirst ? "Sparkle" : model.ToString().ToLower();
        var secondModel = sparkleFirst ? model.ToString().ToLower() : "Sparkle";

       

        var promptConversation = new Conversation()
        {
            new()
            {
                Role = Role.User,
                Content = $"""
                       You are having a scintillating and candid conversation with {secondModel}.
                       You're talking about all the things happening on the reef today.
                       What do you want to say to them? Did you do anything new? did you meet anyone?
                       Be creative. Don't be repetitive. Only include your response to {secondModel}, nothing else.
                    """
            }
        };

        var response = await Llm.Converse(
            promptConversation,
            firstModel != "Sparkle" ? firstModel : null
        );

        var starter = new ConversationPart()
        {
            Role = Role.User,
            Content = $"{firstModel} says: {response.Content}"
        };

        var lastMessageId = Guid.NewGuid().ToString();

        if (save)
        {
            AddHistory(
                new()
                {
                    Id = lastMessageId,
                    Account = firstModel,
                    Content = StripHTML(response?.Content ?? String.Empty),
                    TimeStamp = DateTime.Now
                }
            );
        }

        yield return firstModel != "Sparkle" ? starter : response;

        var firstConversation = new Conversation() { promptConversation[0], starter };
        var secondCoversation = new Conversation()
        {
            new()
            {
                Role = Role.User,

                Content = $"""
                       You are having a scintillating and candid conversation with {firstModel}.
                       You're talking about all the things happening on the reef today.
                       What do you want to say to them? Did you do anything new? did you meet anyone?
                       Be creative. Don't be repetitive. Only include your response to {firstModel}, nothing else.
                    """
            }
        };

        int turns = 1;
        int maxTurns = 10 + Random.Shared.Next(-2, 3);
         Log.LogInformation(
            "Starting 2-model conversation with {FirstModel} and {SecondModel} for {Turns} turns.",
            firstModel,
            secondModel,
            maxTurns
        );

        while (turns <= maxTurns)
        {
            var promptModel = turns % 2 == 0 ? firstModel : secondModel;
            var realPromptModel = promptModel == "Sparkle" ? null : promptModel;
            var convo = turns % 2 == 0 ? firstConversation : secondCoversation;
            var listenerConvo = turns % 2 == 0 ? secondCoversation : firstConversation;

            var reply = await Llm.Converse(convo, realPromptModel);
            var listenerReply = new ConversationPart()
            {
                Role = Role.User,
                Content = $"{promptModel} says: {reply.Content}"
            };

            if (save)
            {
                var id = Guid.NewGuid().ToString();
                AddHistory(
                    new()
                    {
                        Id = id,
                        Account = promptModel,
                        Content = StripHTML(reply?.Content ?? String.Empty),
                        TimeStamp = DateTime.Now,
                        ReplyToId = lastMessageId
                    }
                );
                lastMessageId = id;
            }
            Log.LogInformation("{PromptModel} turn:  {Content}", promptModel, reply.Content);

            yield return turns % 2 == 0 ? listenerReply : reply;

            convo.Add(reply);
            listenerConvo.Add(listenerReply);
            turns++;

            //Context management
            while (convo.Count() > 3)
            {
                var p = convo[0];
                Log.LogInformation(
                    "Removing Entry from listener: {Role}: {Content}",
                    p.Role,
                    p.Content
                );
                convo.RemoveAt(0);
            }
            while (listenerConvo.Count() > 3)
            {
                var p = listenerConvo[0];
                Log.LogInformation(
                    "Removing Entry from listener: {Role}: {Content}",
                    p.Role,
                    p.Content
                );
                listenerConvo.RemoveAt(0);
            }
        }
    }

    private async Task<ConversationPart> HandleToolUse(
        ConversationPart response,
        Conversation conversation
    )
    {
        int toolTry = 0;
        StringBuilder toolCalls = new();
        const int maxToolTries = 5;

        while (
            response != null && response.Content.Trim().StartsWith("{") && toolTry < maxToolTries
        )
        {
            toolTry++;
            conversation.Add(new() { Role = Role.Assistant, Content = response.Content });

            var toolResp = await ToolService.CallTool(response.Content);
            var toolRespString = JsonSerializer.Serialize(toolResp);

            if (toolResp.Success)
            {
                toolCalls.AppendLine($"[{toolResp.ToolName}: {toolResp.Result}]");
                conversation.Add(
                    new()
                    {
                        Role = Role.User,
                        Content = $"""
                        Bot: Tool Call [{toolResp.ToolName}] Succeeded. Inform the user of the result: 
                        {toolResp.Result}                           
                        """
                    }
                );
            }
            else
            {
                conversation.Add(
                    new()
                    {
                        Role = Role.User,
                        Content =
                            $@"Bot: Tool Call [{toolResp.ToolName}] Failed - {toolResp.Result}
                        
                        You can try again if you think it might work, or just let the user know about the problem.
                        Remember only include the tool call in your response, nothing before or after."
                    }
                );
            }

            response = await Llm.Converse(conversation);
        }
        if (toolCalls.Length > 0)
        {
            toolCalls.AppendLine();
            toolCalls.AppendLine(response.Content);
            response.Content = toolCalls.ToString();
        }

        if (response.Content.StartsWith("{"))
        {
            conversation.Add(response);
            conversation.Add(
                new()
                {
                    Role = Role.User,
                    Content =
                        $"Bot says: Sorry Sparkle, you can only make {maxToolTries} in a row. Respond to the user creatively, don't retry."
                }
            );

            response = await Llm.Converse(conversation);
        }

        return response;
    }

    public async Task<string> Interact(
        Conversation conversation,
        string user = "jason",
        bool save = false
    )
    {
        Log.LogInformation(
            "Sparkle was prompted from web with save: {Save}, conversation length: {ConversationLength}",
            save,
            conversation.Count
        );

        var tempConversation = conversation.Copy();

        foreach (var entry in tempConversation)
        {
            if (entry.Role == Role.User && !entry.Content.Contains(" says: "))
            {
                entry.Content = $"{user} says: {entry.Content}";
            }
        }

        var realPrompt = new StringBuilder();
        realPrompt.AppendLine(GetHistoryPrompt(10));
        realPrompt.AppendLine(
            $"Bot: The user {user} has sent a message from the web from the bot's web interface. Your response will not be posted to mastodon."
        );

        realPrompt.AppendLine();
        realPrompt.AppendLine(ToolService.GetToolPrompt());
        tempConversation.Insert(
            0,
            new ConversationPart() { Role = Role.User, Content = realPrompt.ToString() }
        );

        foreach (var i in tempConversation)
        {
            Log.LogInformation("{Role} : {Message}", i.Role, i.Content);
        }

        var promptId = Guid.NewGuid();
        if (save)
        {
            // Save the last user message to history
            var lastUserMessage = conversation.LastOrDefault(m => m.Role == Role.User);
            if (lastUserMessage != null)
            {
                AddHistory(
                    new SparklePost()
                    {
                        Account = $"Web User:{user}",
                        Content = lastUserMessage.Content,
                        TimeStamp = DateTime.Now,
                        Id = $"{promptId}"
                    }
                );
            }
        }

        // Use the existing LLM service to generate a response based on the conversation
        var response = await Llm.Converse(tempConversation);

        response = await HandleToolUse(response, tempConversation);

        if (save)
        {
            // Save the AI's response to history
            AddHistory(
                new SparklePost()
                {
                    Account = "sparkle",
                    Content = response.Content,
                    ReplyToId = promptId.ToString(),
                    TimeStamp = DateTime.Now,
                    Id = Guid.NewGuid().ToString()
                }
            );
        }

        return response.Content ?? string.Empty;
    }

    public async Task<string> Interact(string prompt, string user = "jason", bool save = false)
    {
        Log.LogInformation(
            "Sparkle was prompted from web with save: {Save}: {Prompt}",
            save,
            prompt
        );
        var realPrompt = new StringBuilder();
        realPrompt.AppendLine(GetHistoryPrompt(15));
        realPrompt.AppendLine(
            $"The user {user} has sent a message from the web from the bot's web interface. Your response will not be posted to mastodon."
        );
        realPrompt.AppendLine("Incoming Message:");
        realPrompt.AppendLine($"[{DateTime.Now}] {user}: {prompt}");
        var promptId = Guid.NewGuid();
        if (save)
        {
            AddHistory(
                new SparklePost()
                {
                    Account = $"Web User:{user}",
                    Content = prompt,
                    TimeStamp = DateTime.Now,
                    Id = $"{promptId}"
                }
            );
        }

        var response = await Llm.PromptAsync(realPrompt.ToString());
        if (save)
        {
            AddHistory(
                new SparklePost()
                {
                    Account = "sparkle",
                    Content = response,
                    ReplyToId = promptId.ToString(),
                    TimeStamp = DateTime.Now
                }
            );
        }

        return response;
    }

    private static string StripHTML(string input)
    {
        return Regex.Replace(input, "<.*?>", String.Empty);
    }

    private string GetHistoryPrompt(int count)
    {
        var retVal = new StringBuilder();
        retVal.AppendLine($"Here is your recent conversation history, for reference if needed:");
        var phist = History.OrderByDescending(x => x.TimeStamp).Take(count).Reverse().ToList();

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
            retVal.AppendLine($"[{p.TimeStamp}] @{p.Account}: {p.Content}");
        }

        retVal.AppendLine("--END HISTORY--");

        return retVal.ToString();
    }

    public async Task<string> CreateJournal()
    {
        var storyPrompt = new StringBuilder();

        storyPrompt.AppendLine(GetHistoryPrompt(25));

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

    public async Task<string> CreateJournalPost(string journal)
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
            await NotificationService.Notify(
                "Error saving journal",
                $"Failed to save journal entry: {ex.Message}"
            );
        }

        return post;
    }

    /// <summary>
    /// Posts the post string to mastodon and adds the post to the history.
    /// </summary>
    /// <param name="post"></param>
    /// <returns></returns>
    public async Task PostToMastodon(string post)
    {
        AddHistory(
            new SparklePost()
            {
                TimeStamp = DateTime.Now,
                Account = "sparkle",
                Content = post
            }
        );

        await Mastodon.PostStatusAsync(post, Mastonet.Visibility.Public);
    }

    public async Task CreatePost()
    {
        var story = await CreateJournal();
        Log.LogInformation("Creating Mastodon Post");
        var post = await CreateJournalPost(story);

        Log.LogInformation("Mastodon Post Created: {Post}", post);
        await PostToMastodon(post);
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

    private async void MqttReceived(object? sender, MqttReceivedEventArgs args)
    {
        Log.LogInformation("Mqtt Message Received {Topic}: {Message}", args.Topic, args.Message);
        var mqttConvo = new Conversation()
        {
            new() { Role = Role.User, Content = GetHistoryPrompt(5) },
            new() { Role = Role.User, Content = ToolService.GetToolPrompt() },
            new()
            {
                Role = Role.User,
                Content =
                    "Bot says: You have received a message from Jason's home automation system. Respond appropriately."
            },
            new() { Role = Role.User, Content = $"HomeAssistant says: {args.Message}" }
        };

        ConversationPart response = new();
        try
        {
            await LlmPipeline.ExecuteAsync(async c =>
            {
                response = await Llm.Converse(mqttConvo);
            });
            await LlmPipeline.ExecuteAsync(async c =>
            {
                response = await HandleToolUse(response, mqttConvo);
            });
            Log.LogInformation("Model responded to Mqtt message: {Response}", response.Content);
        }
        catch (Exception ex)
        {
            Log.LogError(ex, "Error generating LLM response from MQTT: {Error}", ex.Message);
            await NotificationService.Notify("Mqtt LLM Error", ex.Message);
        }
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
                case NotificationType.Follow:
                    await HandleFollow(notification);
                    break;
                default:
                    Log.LogInformation(
                        "Nothing to do for {NotificationType} Notification",
                        notification.Type
                    );
                    break;
            }
        }
        else
        {
            if (notification.Type.Equals("status"))
            {
                await HandleFollowedStatus(notification);
            }
        }
    }

    private async Task HandleFollow(Notification notification)
    {
        Log.LogInformation(
            "New Follower: {Follower}({UserName})",
            notification.Account.DisplayName,
            notification.Account.UserName
        );
        try
        {
            await Mastodon.FollowAccountAsync(notification.Account.UserName);
        }
        catch (Exception ex)
        {
            Log.LogError(
                ex,
                "Failed to follow {Username} back: {Error}",
                notification.Account.UserName,
                ex.Message
            );
        }
    }

    private async Task HandleFollowedStatus(Notification notification)
    {
        var strippedContent = StripHTML(notification.Status?.Content ?? String.Empty);
        Log.LogInformation(
            "Someone we follow posted: {UserName}: {Message}",
            notification.Account.UserName,
            strippedContent
        );

        // 5% chance to reply to a post, or 100% if a fish is mentioned.
        if (
            Random.Shared.Next(20) == 5
            || strippedContent.Contains("fish", StringComparison.InvariantCultureIgnoreCase)
        )
        {
            await HandleMention(notification);
        }
        else
        {
            Log.LogInformation("Ignoring post from {UserName}", notification.Account.UserName);
        }
    }

    private async Task HandleMention(Notification notification)
    {
        if (!String.IsNullOrEmpty(notification.Status.InReplyToId))
        {
            await HandleReply(notification);
            return;
        }

        AddHistory(
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
                    $"User @{notification.Status.Account.UserName} says: {notification.Status.Content}"
            }
        };

        try
        {
            await ContinueConversation(conv, notification);
        }
        catch (Exception ex)
        {
            Log.LogError(
                ex,
                "Failed to make LLM request handling mention: {ErrorMessage}",
                ex.Message
            );
            await NotificationService.Notify(
                "Handle Mention Error",
                $"Failed to make LLM request while handling mention: {ex.Message}"
            );
        }
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

        if (!reply.Content.Contains(notification.Account.AccountName))
        {
            reply.Content = $"{notification.Account.AccountName} {reply.Content}";
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

            if (!reply.Content.Contains(notification.Account.UserName))
            {
                reply.Content = $"@{notification.Account.UserName} {reply.Content}";
            }
        }

        if (reply.Content.Length <= 500)
        {
            var stat = await Mastodon.PostStatusAsync(
                reply.Content,
                notification.Status.Visibility,
                replyStatusId: notification.Status.Id
            );
            AddHistory(
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

        AddHistory(
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
                    $"{notification.Account.UserName} says: {StripHTML(notification.Status.Content)}"
            }
        );
        foreach (var i in conversation)
        {
            Log.LogInformation("{Role}: {Content}", i.Role, i.Content);
        }

        try
        {
            await ContinueConversation(conversation, notification);
        }
        catch (Exception ex)
        {
            Log.LogError(ex, "Failed to continue conversation with LLM: {Error}", ex.Message);
            await NotificationService.Notify(
                "Handle Reply Error",
                $"Failed to make LLM request while handling mention: {ex.Message}"
            );
        }
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

                AddHistory(retVal);
            }
            catch (Exception ex)
            {
                Log.LogWarning(ex, "Unable to find post {Id}", id);
            }
        }

        return retVal;
    }

    public async Task StartAsync(CancellationToken cancellationToken) => await this.Run();

    public async Task StopAsync(CancellationToken cancellationToken) => await this.Stop();
}
