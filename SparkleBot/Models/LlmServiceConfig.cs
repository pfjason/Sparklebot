namespace SparkleBot.Models
{
    /// <summary>
    /// Represents the Language Model (LLM) service configuration settings,
    /// ready to be bound from IConfiguration.
    /// </summary>
    public class LlmServiceConfig
    {
        public string EndpointUrl { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        public string Jwt { get; set; } = string.Empty;

        /// <summary>
        /// Knowledge base uuid from OpenWebUI
        /// </summary>
        public string? KnowledgeId { get; set; }
    }
}
