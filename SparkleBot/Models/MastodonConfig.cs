namespace SparkleBot.Models
{
    /// <summary>
    /// Represents the Mastodon configuration settings, ready to be bound from IConfiguration.
    /// </summary>
    public class MastodonConfig
    {
        public string InstanceUrl { get; set; } = string.Empty;
        public string AccessToken { get; set; } = string.Empty;
    }
}
