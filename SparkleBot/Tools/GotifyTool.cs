using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Logging;
using Polly;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Tools;

public class NotificationTool : ToolBase
{
    #region Property Injections
    public required ILogger<NotificationTool> Log { private get; init; }
    public required INotificationService GotifyService { private get; init; }
    #endregion

    public override string Prompt => "Sends a Notification to Jason";

    public override string Name => "notify_service";

    public override IEnumerable<Parameter> Parameters =>
        new List<Parameter>()
        {
            new Parameter()
            {
                Name = "message",
                PromptDescription = "The text of the notification to be sent",
                Type = ParameterType.String
            }, 

            new Parameter()
            {
                Name = "priority",
                PromptDescription = "The priority of the message (0 - 10) 0 is unimportant, 10 is emergency",
                Type = ParameterType.Number
            }
        };

    public override async Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        if (TryGetParameter("message", parameters, out var msgParam)
            && TryGetParameter("priority", parameters, out var p1)
            && Int32.TryParse(p1.ToString(), out var priority)
            )
        {
            Log.LogInformation(
                "The Notification Tool was called with message: {Message}",
                msgParam
            );

            await GotifyService.Notify($"Message from Sparkle", msgParam?.ToString(), priority: priority);

            return new ToolResponse()
            {
                Result = $"The priority {priority} message was sent: {msgParam}",
                Success = true,
                ToolName = this.Name
            };
        }
        else
        {
            return new ToolResponse()
            {
                Result = $"ERROR: message parameter was missing from the call to {this.Name}",
                Success = false,
                ToolName = this.Name
            };
        }
    }
}
