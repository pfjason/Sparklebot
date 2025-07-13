using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class ToolService : IToolService
{
    #region Property Injections
    public required IEnumerable<ITool> Tools { private get; init; }
    public required ILogger<ToolService> Log { private get; init; }
    #endregion

    private JsonSerializerOptions Opts = new() { PropertyNameCaseInsensitive = true };

    private const string TOOL_HEADER = """
        You have access to tools. You are an expert at using them.
        If you decide to invoke any of the tool(s), you MUST put it in the format of

        {"name": "tool name", "parameters": dictionary of argument name and its value}

        You have access to the following tools:
        """;

    private const string TOOL_FOOTER = """
         CRITICAL:
          If you decide to call a tool, you MUST NOT include any other text in the response other than the tool call 
          or the tool will not be called. Only call tools when it's appropriate.
        """;

    public ToolService() { }

    public string GetToolPrompt()
    {
        if (Tools.Count() == 0)
        {
            return String.Empty;
        }

        var retVal = new StringBuilder(TOOL_HEADER);

        foreach (var tool in Tools)
        {
            // Only include enabled tools
            if (!tool.Enabled)
                continue;

            // Add tool name and description
            retVal.AppendLine($"- {tool.Name}: {tool.Prompt}");

            // Add tool parameters details
            retVal.AppendLine("  Parameters:");
            foreach (var parameter in tool.Parameters)
            {
                retVal.AppendLine(
                    $"    - {parameter.Name}: {parameter.PromptDescription} (Type: {parameter.Type})"
                );
            }
            retVal.AppendLine(); // Add a blank line between tools for readability
        }
        retVal.AppendLine(TOOL_FOOTER);

        return retVal.ToString();
    }

    public async Task<ToolResponse> CallTool(string toolCall)
    {
        try
        {
            var call = JsonSerializer.Deserialize<ToolCall>(toolCall.Trim(), Opts);
            if (call == null)
            {
                return new()
                {
                    Success = false,
                    ToolName = "unknown",
                    Result = "Failed to parse your tool call. The toolCall parsed to null."
                };
            }
            return await CallTool(call);
        }
        catch (Exception ex)
        {
            Log.LogWarning(
                ex,
                "Failed to parse tool call: {Error} // {ToolCall}",
                ex.Message,
                toolCall
            );

            return new()
            {
                Result = $"Tool parser was unable to parse your tool call: {ex.Message}",
                Success = false,
                ToolName = "unknown"
            };
        }
    }

    public async Task<ToolResponse> CallTool(ToolCall call)
    {
        var tool = Tools.FirstOrDefault(x =>
            x.Name.Equals(call.Name, StringComparison.InvariantCultureIgnoreCase)
        );
        if (tool == null)
        {
            return new()
            {
                Result = $"The requested tool {call.Name} was not found.",
                Success = false,
                ToolName = call.Name
            };
        }
        return await tool.Execute(call.Parameters);
    }
}
