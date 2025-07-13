namespace SparkleBot.Models;

public class ToolResponse
{
    public required string ToolName { get; init; }
    public required string Result { get; init; }
    public required bool Success { get; init; }
}
