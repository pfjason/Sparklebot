using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;
using SparkleBot.Services;

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
            }
        };

    public override async Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        if (TryGetParameter("message", parameters, out var msgParam))
        {
            Log.LogInformation(
                "The Notification Tool was called with message: {Message}",
                msgParam
            );

            await GotifyService.Notify($"Message from Sparkle", msgParam?.ToString(), priority: 1);

            return new ToolResponse()
            {
                Result = $"The message was sent: {msgParam}",
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
