using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;
using SparkleBot.Services;

namespace SparkleBot.Tools;

public class NotificationTool : ITool
{
    #region Property Injections
    public required ILogger<NotificationTool> Log { private get; init; }
    public required INotificationService GotifyService { private get; init; }
    #endregion

    public bool Enabled { get; set; } = true;
    public string Prompt => "Sends a Notification to Jason";

    public string Name => "notify_service";

    public IEnumerable<Parameter> Parameters => new List<Parameter>()
    {
        new Parameter() {
             Name = "message",
              PromptDescription = "The text of the notification to be sent",
               Type =  ParameterType.String
        }
    };

    public async Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        var msgParam = parameters.FirstOrDefault(k =>
           k.Key.Equals("message", StringComparison.InvariantCultureIgnoreCase)
       );

        if (String.IsNullOrWhiteSpace(msgParam.Key))
        {
            return
                new ToolResponse()
                {
                    Result = $"ERROR: message parameter was missing from the call to {this.Name}",
                    Success = false,
                    ToolName = this.Name
                };
            
        }
        
         Log.LogInformation("The Notification Tool was called with message: {Message}", msgParam.Value);


        await GotifyService.Notify($"Message from Sparkle", msgParam.Value?.ToString(), priority: 1);

        return
            new ToolResponse()
            {
                Result = $"The message was sent: {msgParam.Value}",
                Success = true,
                ToolName = this.Name
            };
        
        
        
    }
}
