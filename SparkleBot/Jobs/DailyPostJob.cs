using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;

namespace SparkleBot.Jobs;

public class ScheduledPostJob : IAsyncJob
{
    public required ISparkleService Sparkle { private get; init; }
    public required ILogger<ScheduledPostJob> Log { private get; init; }

    public async Task ExecuteAsync()
    {
        try
        {
            Log.LogInformation("Begin daily post job");
            await Sparkle.CreatePost();
            Log.LogInformation("Daily post job completed.");
        }
        catch (Exception ex)
        {
            Log.LogError(ex, "Failed to create daily post: {Error}", ex.Message);
        }
    }

}