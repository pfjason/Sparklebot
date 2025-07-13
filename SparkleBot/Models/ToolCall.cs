namespace SparkleBot.Models;

public class ToolCall
{
    /// <summary>
    /// Name of the tool
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Dictionary of parameters
    /// </summary>
    public Dictionary<string, object> Parameters { get; init; } = new();
}
