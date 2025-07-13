namespace SparkleBot.Models;

public class Parameter
{
    public required string PromptDescription { get; init; }
    public required string Name { get; init; }
    public ParameterType Type { get; init; }
}
