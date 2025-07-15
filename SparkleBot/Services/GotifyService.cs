using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Polly;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class GotifyService : INotificationService
{
    public required GotifyConfig Config { private get; init; }
    public required ILogger<GotifyService> Log { private get; init; }

    private ResiliencePipeline? RetryPipeline;

    private void CreateRetryPipeline()
    {
        if (RetryPipeline == null)
        {
            RetryPipeline = new ResiliencePipelineBuilder()
                .AddRetry(
                    new Polly.Retry.RetryStrategyOptions()
                    {
                        Delay = TimeSpan.FromSeconds(5),
                        BackoffType = DelayBackoffType.Linear,
                        OnRetry = (c) =>
                        {
                            Log.LogWarning(
                                "Retrying Gotify Request RetryCount:{RetryCount}",
                                c.AttemptNumber
                            );
                            return ValueTask.CompletedTask;
                        },
                        MaxRetryAttempts = 10
                    }
                )
                .Build();
        }
    }

    public async Task Notify(string title, string message, int priority = 0)
    {
        CreateRetryPipeline();
        try
        {
            await RetryPipeline.ExecuteAsync(async ct =>
                await RealNotify(title, message, priority, ct)
            );
        }
        catch (Exception ex)
        {
            Log.LogError(
                ex,
                "Gotify Notification failed after maximum retries: {Error}",
                ex.Message
            );
        }
    }

    private async Task RealNotify(
        string title,
        string message,
        int priority = 0,
        CancellationToken cancellationToken = default
    )
    {
        using var client = new HttpClient();
        client.BaseAddress = Config.BaseUri;

        var payload = new
        {
            title,
            message,
            priority
        };

        var content = new StringContent(
            JsonSerializer.Serialize(payload),
            Encoding.UTF8,
            "application/json"
        );

        try
        {
            var response = await client.PostAsync(
                $"/message?token={Config.ApiKey}",
                content,
                cancellationToken
            );
            response.EnsureSuccessStatusCode();

            Log.LogInformation("Gotify notification sent successfully.");
        }
        catch (HttpRequestException ex)
        {
            Log.LogError(ex, "Failed to send Gotify notification.");
        }
    }
}
