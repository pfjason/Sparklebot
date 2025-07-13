using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MQTTnet;
using Polly;
using Serilog;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

/// <summary>
/// Service for managing MQTT connections and message subscriptions
/// </summary>
public class MqttService : IMqttService, IDisposable
{
    #region Property Injections

    public required ILogger<MqttService> Log { private get; init; }
    public required MqttConfiguration Configuration { private get; init; }

    #endregion

    /// <summary>
    /// Event fired when an MQTT message is received
    /// </summary>
    public event EventHandler<MqttReceivedEventArgs>? MessageReceived;

    private ResiliencePipeline ConnectPipeline;

    private ResiliencePipeline CreateConnectPipeline() =>
        new ResiliencePipelineBuilder()
            .AddRetry(
                new Polly.Retry.RetryStrategyOptions()
                {
                    BackoffType = DelayBackoffType.Linear,
                    MaxDelay = TimeSpan.FromMinutes(1),
                    UseJitter = true,
                    Delay = TimeSpan.FromSeconds(5),
                    OnRetry = r =>
                    {
                        Log.LogWarning("MqttConnection attempt failed, retrying...");
                        return ValueTask.CompletedTask;
                    }
                }
            )
            .Build();

    private IMqttClient? mqttClient = null;
    private bool disposedValue;

    /// <summary>
    /// Initializes a new instance of the MqttService with DI
    /// </summary>
    public MqttService() { }

    public async Task StartAsync()
    {
        if (!Configuration.Enabled)
        {
            return;
        }
        if (mqttClient == null)
        {
            mqttClient = new MqttClientFactory().CreateMqttClient();
            if (ConnectPipeline == null)
            {
                ConnectPipeline = CreateConnectPipeline();
            }
            mqttClient.ConnectedAsync += MqttClient_Connected;
            mqttClient.DisconnectedAsync += MqttClient_Disconnected;
            mqttClient.ApplicationMessageReceivedAsync += MqttClient_MessageReceived;

            var opts = new MqttClientOptionsBuilder()
                .WithConnectionUri(Configuration.Server)
                .WithCredentials(
                    new MqttClientCredentials(
                        Configuration.User,
                        Encoding.UTF8.GetBytes(Configuration.Password)
                    )
                )
                .WithWillTopic($"{Configuration.WriteTopic}/LWT")
                .WithProtocolVersion(MQTTnet.Formatter.MqttProtocolVersion.V500)
                .Build();
            await ConnectPipeline.ExecuteAsync(async c =>
            {
                var connectResult = await mqttClient.ConnectAsync(opts);
                if (!mqttClient.IsConnected)
                {
                    throw new Exception("Mqtt Client was not connected after connect");
                }
            });
            var subOpts = new MqttClientSubscribeOptionsBuilder()
                .WithTopicFilter(
                    new MqttTopicFilterBuilder()
                        .WithAtMostOnceQoS()
                        .WithTopic(Configuration.ReadTopic)
                        .Build()
                )
                .Build();
            var sub = await mqttClient.SubscribeAsync(subOpts);
        }
    }

    private Task MqttClient_Disconnected(MqttClientDisconnectedEventArgs args)
    {
        Log.LogInformation("Mqtt Client Disconnected: {Reason}", args.ReasonString);
        return Task.CompletedTask;
    }

    private Task MqttClient_Connected(MqttClientConnectedEventArgs args)
    {
        Log.LogInformation("Mqtt Client Connected");
        return Task.CompletedTask;
    }

    public async Task SendMessageAsync(string message)
    {
        if (!Configuration.Enabled || mqttClient == null)
        {
            throw new InvalidOperationException("Mqtt is disconnected or disabled");
        }

        await mqttClient.PublishStringAsync(
            Configuration.WriteTopic,
            message,
            MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce,
            retain: true
        );
    }

    private async Task MqttClient_MessageReceived(MqttApplicationMessageReceivedEventArgs args)
    {
        await args.AcknowledgeAsync(CancellationToken.None);
        MessageReceived?.Invoke(
            this,
            new MqttReceivedEventArgs()
            {
                Message = args.ApplicationMessage.ConvertPayloadToString(),
                Topic = args.ApplicationMessage.Topic
            }
        );
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                mqttClient?.Dispose();
            }
            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
