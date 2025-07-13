using Mastonet;
using Mastonet.Entities;

namespace SparkleBot.Interfaces;

public interface IMastodonService
{
    event EventHandler<Notification> NotificationReceived;
    event EventHandler<Conversation> ConversationRecieved;
    Task<IEnumerable<Status>> GetLastSentPostsAsync(int posts = 100);
    Task StartAsync();
    Task<Status> PostStatusAsync(
        string statusText,
        Visibility visibility = Visibility.Public,
        string? replyStatusId = null
    );

    Task<Status> GetStatusByIdAsync(string statusId);

    Task<IEnumerable<Status>> GetRepliesAsync(string statusId);

    /// <summary>
    /// Follows a Mastodon account by its account name or ID.
    /// </summary>
    /// <param name="accountIdentifier">The account name (e.g., "@username@instance.social") or account ID.</param>
    /// <returns>The Account object of the followed account.</returns>
    Task<Account> FollowAccountAsync(string accountIdentifier);
}
