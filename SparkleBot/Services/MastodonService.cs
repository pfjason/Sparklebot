using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mastonet;
using Mastonet.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces; // Still needed for IConfiguration

namespace SparkleBot.Services;

public class MastodonService : IMastodonService
{
    // Reverted logger back to your original required property
    public required ILogger<MastodonService> Log { private get; init; }
    private readonly IConfiguration _configuration; // Still needed for configuration
    private MastodonClient _client;
    private TimelineStreaming userStreaming;
    private Account _currentUserAccount; // Stores our authenticated account details

    // Event to fire when a notification is received
    public event EventHandler<Notification> NotificationReceived;
    public event EventHandler<Conversation> ConversationRecieved;

    private Task streamingTask;

    // We'll keep IConfiguration in the constructor as it's not a 'required' property type
    public MastodonService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Initializes the Mastodon client and authenticates with the instance.
    /// This must be called before using other methods.
    /// </summary>
    public async Task StartAsync()
    {
        // Use the 'Log' property directly now
        Log.LogInformation("Initializing Mastodon service...");
        var instanceUrl = _configuration["Mastodon:InstanceUrl"];
        var accessToken = _configuration["Mastodon:AccessToken"];

        if (string.IsNullOrEmpty(instanceUrl) || string.IsNullOrEmpty(accessToken))
        {
            Log.LogError(
                "Mastodon 'InstanceUrl' or 'AccessToken' not configured. Please check appsettings.json."
            );
            throw new InvalidOperationException(
                "Mastodon configuration missing. Cannot initialize service."
            );
        }

        _client = new MastodonClient(instanceUrl, accessToken);

        _currentUserAccount = await _client.GetCurrentUser();
        Log.LogInformation(
            "Successfully connected to Mastodon as @{Username} ({InstanceUrl})",
            _currentUserAccount.AccountName,
            instanceUrl
        );
        userStreaming = _client.GetUserStreaming();
        userStreaming.OnConversation += OnConversation;
        userStreaming.OnNotification += OnNotification;
        streamingTask = userStreaming.Start();
    }

#nullable disable
    private void OnConversation(object sender, StreamConversationEvenTargs eventArgs) =>
        ConversationRecieved?.Invoke(this, eventArgs.Conversation);

    private void OnNotification(object sender, StreamNotificationEventArgs eventArgs) =>
        NotificationReceived?.Invoke(this, eventArgs.Notification);

#nullable enable

    /// <summary>
    /// Posts a new status (toot) to Mastodon.
    /// </summary>
    /// <param name="statusText">The text content of the status.</param>
    /// <param name="visibility">Optional: The visibility of the status (default Public).</param>
    /// <returns>The posted Status object.</returns>
    public async Task<Status> PostStatusAsync(
        string statusText,
        Visibility visibility = Visibility.Public,
        string? ReplyStatusId = null
    )
    {
        if (_client == null)
        {
            throw new InvalidOperationException(
                "MastodonService is not initialized. Call InitializeAsync() first."
            );
        }

        Log.LogInformation("Attempting to post status: {StatusText}", statusText);
        var status = await _client.PublishStatus(statusText, visibility: visibility, replyStatusId: ReplyStatusId);
        Log.LogInformation("Status posted successfully. ID: {StatusId}", status.Id);
        return status;
    }

    /// <summary>
    /// Gets the last 10 posts sent by the authenticated user.
    /// </summary>
    /// <returns>A list of Status objects.</returns>
    public async Task<IEnumerable<Status>> GetLast10SentPostsAsync()
    {
        if (_client == null || _currentUserAccount == null)
        {
            throw new InvalidOperationException(
                "MastodonService is not initialized or current user account not retrieved. Call StartAsync() first."
            );
        }

        try
        {
            Log.LogInformation(
                "Retrieving last 100 posts for account {AccountId}",
                _currentUserAccount.Id
            );
            // Mastonet's GetAccountStatuses provides 'limit' parameter
            var statuses = await _client.GetAccountStatuses(
                _currentUserAccount.Id,
                options: new ArrayOptions() { Limit = 100 }
            );
            Log.LogInformation("Retrieved {Count} posts.", statuses.Count());
            return statuses;
        }
        catch (Exception ex)
        {
            Log.LogError(
                ex,
                "Failed to retrieve last 10 posts for account {AccountId}.",
                _currentUserAccount.Id
            );
            throw;
        }
    }

     /// <summary>
    /// Retrieves a specific status (toot) by its ID.
    /// </summary>
    /// <param name="statusId">The ID of the status to retrieve.</param>
    /// <returns>The Status object if found.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the MastodonService is not initialized.</exception>
    /// <exception cref="Exception">Thrown if the status retrieval fails.</exception>
    public async Task<Status> GetStatusByIdAsync(string statusId)
    {
        if (_client == null)
        {
            throw new InvalidOperationException(
                "MastodonService is not initialized. Call StartAsync() first."
            );
        }

        try
        {
            Log.LogInformation("Attempting to retrieve status with ID: {StatusId}", statusId);
            var status = await _client.GetStatus(statusId);
            if (status != null)
            {
                Log.LogInformation("Status with ID {StatusId} retrieved successfully.", statusId);
            }
            else
            {
                Log.LogWarning("Status with ID {StatusId} not found.", statusId);
            }
            return status;
        }
        catch (Exception ex)
        {
            Log.LogError(ex, "Failed to retrieve status with ID: {StatusId}", statusId);
            throw;
        }
    }
    

}
