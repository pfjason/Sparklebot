using Mastonet;
using Mastonet.Entities;

namespace SparkleBot.Interfaces;

public interface IMastodonService
{
    event EventHandler<Notification> NotificationReceived;
    event EventHandler<Conversation> ConversationRecieved;
    Task<IEnumerable<Status>> GetLast10SentPostsAsync();
    Task StartAsync();
    Task<Status> PostStatusAsync(
        string statusText,
        Visibility visibility = Visibility.Public,
        string? replyStatusId = null
    );

     Task<Status> GetStatusByIdAsync(string statusId);
}
