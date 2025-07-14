namespace SparkleBot.Models
{
    /// <summary>
    /// Event arguments for MQTT message received events
    /// </summary>
    public class MqttReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// The topic from which the message was received
        /// </summary>
        public required string Topic { get; init; }

        /// <summary>
        /// The message payload as a string
        /// </summary>
        public required string Message { get; init; }

       
    }
}