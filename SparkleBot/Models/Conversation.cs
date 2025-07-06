namespace SparkleBot.Models;

public class Conversation : List<ConversationPart>
{
    public Conversation()
    {
    }

    public Conversation(IEnumerable<ConversationPart> collection) : base(collection)
    {
    }

    public Conversation(int capacity) : base(capacity)
    {
    }
}
