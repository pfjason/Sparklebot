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
}
