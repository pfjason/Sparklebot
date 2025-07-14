using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class GotifyService : INotificationService
{
    public required GotifyConfig Config { private get; init; }
    public required ILogger<GotifyService> Log { private get; init; }

    public async Task Notify(string title, string message, int priority = 0)
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
            var response = await client.PostAsync($"/message?token={Config.ApiKey}", content);
            response.EnsureSuccessStatusCode();

            Log.LogInformation("Gotify notification sent successfully.");
        }
        catch (HttpRequestException ex)
        {
            Log.LogError(ex, "Failed to send Gotify notification.");
        }
    }
}
