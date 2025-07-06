using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Org.OpenAPITools.Api;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class LlmService : IDisposable, ILlmService
{
    public required ILogger<LlmService> Log { private get; init; }
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;

    public string Model => _modelName;
    public string Endpoint => _endpointUrl;

    private readonly string _endpointUrl;
    private readonly string _apiKey;
    private readonly string _modelName;
    private bool disposedValue;

    private JsonSerializerOptions jsonOpts = new JsonSerializerOptions
    {
        WriteIndented = false,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new JsonStringEnumConverter() }
    };

    public LlmService(IConfiguration configuration)
    {
        _configuration = configuration;
        _httpClient = new HttpClient();
        _httpClient.Timeout = TimeSpan.FromMinutes(5);

        // Retrieve LLM settings from configuration
        _endpointUrl =
            _configuration["LlmService:EndpointUrl"]
            ?? throw new InvalidOperationException("LlmService:EndpointUrl is not configured.");
        _apiKey =
            _configuration["LlmService:ApiKey"]
            ?? throw new InvalidOperationException("LlmService:ApiKey is not configured.");
        _modelName = _configuration["LlmService:Model"] ?? "gpt-3.5-turbo"; // Default model if not specified

        // Set up HttpClient
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            _apiKey
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
    public async Task<string> PromptAsync(string userPrompt, string systemPrompt = null)
    {
        Log.LogDebug("Sending prompt to LLM: {UserPrompt}", userPrompt);

        var messages = new Conversation();
        if (!string.IsNullOrEmpty(systemPrompt))
        {
            messages.Add(new() { Role = Role.System, Content = systemPrompt });
        }
        messages.Add(new() { Role = Role.User, Content = userPrompt });

        var cp = await Converse(messages);
        return cp.Content ?? String.Empty;
    }

    public async Task<ConversationPart> Converse(Conversation conversation)
    {
        var requestBody = new
        {
            model = _modelName,
            messages = conversation,
            temperature = .9 // A common default, adjust as needed
        };

        var jsonBody = JsonSerializer.Serialize(requestBody, jsonOpts);

        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_endpointUrl}/api/chat/completions", content);
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
