using SparkleBot.Models;

namespace SparkleBot.Interfaces;

public interface IToolService
{
    Task<ToolResponse> CallTool(string toolCall);
    Task<ToolResponse> CallTool(ToolCall call);
    string GetToolPrompt();
}
