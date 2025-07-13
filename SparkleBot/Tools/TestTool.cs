using Microsoft.Extensions.Logging;
using SparkleBot.Models;

namespace SparkleBot.Tools;

public class TestTool : ITool
{
    #region Property Injections
    public required ILogger<TestTool> Log { private get; init; }
    #endregion

    public bool Enabled { get; set; } = false;

    public string Prompt => "Adds a message to the system log.";

    public string Name => "write_log_message";

    public IEnumerable<Parameter> Parameters { get; private set; } =
        new List<Parameter>()
        {
            new Parameter
            {
                Name = "message",
                PromptDescription = "The message to add to the log",
                Type = ParameterType.String
            }
        };

    public Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        var msgParam = parameters.FirstOrDefault(k =>
            k.Key.Equals("message", StringComparison.InvariantCultureIgnoreCase)
        );

        if (String.IsNullOrWhiteSpace(msgParam.Key))
        {
            return Task.FromResult(
                new ToolResponse()
                {
                    Result = $"ERROR: message parameter was missing from the call to {this.Name}",
                    Success = false,
                    ToolName = this.Name
                }
            );
        }

        Log.LogInformation("The Log Tool was called with message: {Message}", msgParam.Value);
        return Task.FromResult(
            new ToolResponse()
            {
                Result = $"The message was added to the log: {msgParam.Value}",
                Success = true,
                ToolName = this.Name
            }
        );
    }
}
