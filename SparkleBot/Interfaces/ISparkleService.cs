using SparkleBot.Enums;
using SparkleBot.Models;

namespace SparkleBot.Interfaces;

public interface ISparkleService
{
    List<SparklePost> History { get; }

    string ReadyMessage { get; }

    Task Run();

    Task RunAndWait();

    Task Stop();

    Task CreatePost();

    Task<string> Interact(string prompt, string user, bool save = false);
    Task<string> Interact(Conversation conversation, string user = "jason", bool save = false);


    Task<string> CreateJournal();
    Task<string> CreateJournalPost(string journal);
    Task PostToMastodon(string post);

    /// <summary>
    /// Creates a conversation between sparkle and one of the friend models
    /// </summary>
    /// <param name="model"></param>
    /// <param name="sparkleFirst"></param>
    /// <returns></returns>
    IAsyncEnumerable<ConversationPart> ConverseWithModel(FriendModel model, bool sparkleFirst, bool save = false);
    

}