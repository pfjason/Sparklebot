namespace SparkleBot.Models;

public class SparkleConfig
{
    /// <summary>
    /// Schedule in cron notation for posting to mastodon
    /// </summary>
    public string? PostSchedule { get; set; } = "18 18 * * *";

}