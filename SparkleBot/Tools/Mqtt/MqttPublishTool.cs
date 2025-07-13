using System;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Tools.Mqtt;

public class MqttPublishTool : ToolBase
{
    #region  Property Injections
    public required ILogger<MqttPublishTool> Log { private get; init; }
    public required IMqttService MqttService { private get; init; }
    #endregion

    public override bool Enabled
    {
        get => base.Enabled && config.Enabled;
        set => base.Enabled = value;
    }
    private MqttConfiguration config;

    public MqttPublishTool(MqttConfiguration config)
    {
        this.Enabled = config.Enabled;
        this.config = config;
    }

    public override string Prompt => "Sends a message to the MQTT service";

    public override string Name => "mqtt_publish";

    public override IEnumerable<Parameter> Parameters =>
        new List<Parameter>()
        {
            new()
            {
                Name = "message",
                PromptDescription = "Message to send to the server",
                Type = ParameterType.String
            }
        };

    public override async Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        if (TryGetParameter("message", parameters, out var messageParam))
        {
            Log.LogInformation(
                "The Mqtt Publish Tool was called with message: {Message}",
                messageParam
            );
            try
            {
                await MqttService.SendMessageAsync(messageParam?.ToString());

                return new ToolResponse()
                {
                    Success = true,
                    Result = $"The message \"{messageParam}\" has been successfully sent.",
                    ToolName = Name
                };
            }
            catch (Exception ex)
            {
                var error = $"MQTT Publish failed with error: {ex.Message}";
                Log.LogWarning(ex, error);
                return new ToolResponse()
                {
                    Success = false,
                    Result = error,
                    ToolName = Name
                };
            }
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
