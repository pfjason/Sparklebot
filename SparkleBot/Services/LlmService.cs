using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Polly;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class LlmService : IDisposable, ILlmService
{
    public required ILogger<LlmService> Log { private get; init; }
    public required LlmServiceConfig Config { private get; init; }
    private readonly HttpClient _httpClient;

    public string Model => Config.Model;
    public string Endpoint => Config.EndpointUrl;

    private bool disposedValue;

    private JsonSerializerOptions jsonOpts = new JsonSerializerOptions
    {
        WriteIndented = false,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new JsonStringEnumConverter() }
    };
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

    public LlmService(LlmServiceConfig config)
    {
        this.Config = config;

        _httpClient = new HttpClient();
        _httpClient.Timeout = TimeSpan.FromMinutes(5);

        // Set up HttpClient
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            Config.ApiKey
        );

        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

    /// <summary>
    /// Prompts an OpenAI-compatible LLM endpoint and returns the generated text.
    /// </summary>
    /// <param name="userPrompt">The user's input prompt.</param>
    /// <param name="systemPrompt">Optional: A system-level prompt to guide the LLM's behavior.</param>
    /// <returns>The LLM's generated response string.</returns>
    /// <exception cref="HttpRequestException">Thrown if the HTTP request to the LLM endpoint fails.</exception>
    /// <exception cref="JsonException">Thrown if the response from the LLM endpoint cannot be parsed as JSON.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the LLM response is missing the expected content.</exception>
    /// <exception cref="Exception">Thrown for any other unexpected errors.</exception>
    public async Task<string> PromptAsync(string userPrompt, string? systemPrompt = null, string? model = null)
    {
        Log.LogDebug("Sending prompt to LLM: {UserPrompt}", userPrompt);

        var messages = new Conversation();
        if (!string.IsNullOrEmpty(systemPrompt))
        {
            messages.Add(new() { Role = Role.System, Content = systemPrompt });
        }
        messages.Add(new() { Role = Role.User, Content = userPrompt });

        var cp = await Converse(messages, model);
        return cp.Content ?? String.Empty;
    }

    public async Task<ConversationPart> Converse(Conversation conversation, string? model = null)
    {
        var requestBody = new
        {
            model = model ?? Config.Model,
            messages = conversation,
            temperature = .9 // A common default, adjust as needed
        };

        var jsonBody = JsonSerializer.Serialize(requestBody, jsonOpts);

        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{Config.EndpointUrl}/api/chat/completions", content);
        response.EnsureSuccessStatusCode(); // Throws HttpRequestException for 4xx/5xx status codes

        var responseString = await response.Content.ReadAsStringAsync();

        // Parse the JSON response
        using (JsonDocument doc = JsonDocument.Parse(responseString))
        {
            // Navigate to choices[0].message.content
            if (
                doc.RootElement.TryGetProperty("choices", out JsonElement choicesElement)
                && choicesElement.EnumerateArray().Any()
                && choicesElement
                    .EnumerateArray()
                    .First()
                    .TryGetProperty("message", out JsonElement messageElement)
                && messageElement.TryGetProperty("content", out JsonElement contentElement)
            )
            {
                var llmResponse = contentElement.GetString();
                Log.LogDebug(
                    "Received LLM response (first {Length} chars): {LlmResponse}",
                    Math.Min(llmResponse.Length, 100),
                    llmResponse.Substring(0, Math.Min(llmResponse.Length, 100))
                );
                return new ConversationPart() { Role = Role.Assistant, Content = llmResponse };
            }
        }

        // If we reach here, the response structure was not as expected
        throw new InvalidOperationException(
            $"LLM response did not contain expected 'choices[0].message.content'. Full response: {responseString}"
        );
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                this._httpClient?.Dispose();
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
