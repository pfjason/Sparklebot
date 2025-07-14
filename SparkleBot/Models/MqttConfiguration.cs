namespace SparkleBot.Models;

public class MqttConfiguration
{
    public bool Enabled { get; set; }
    public string? Server { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public string? ReadTopic { get; set; }
    public string? WriteTopic { get; set; }
    public string? ClientId { get; set; }
}
