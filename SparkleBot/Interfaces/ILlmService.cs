using SparkleBot.Models;

namespace SparkleBot.Interfaces;

public interface ILlmService : IDisposable
{
    public string Model { get; }
    public string Endpoint { get; }
    Task<string> PromptAsync(string userPrompt, string? systemPrompt = null, string? model = null);

    Task<ConversationPart> Converse(Conversation conversation, string? model = null);
}
