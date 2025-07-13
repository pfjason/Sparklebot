using SparkleBot.Models;

namespace SparkleBot.Interfaces;

public interface IMqttService
{
    event EventHandler<MqttReceivedEventArgs>? MessageReceived;

    Task SendMessageAsync(string message);
    Task StartAsync();
}
