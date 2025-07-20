using System.IO.Abstractions;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Services;

public class JournalService : IJournalService, IDisposable
{
    public required IFileSystem FileSystem { private get; init; }
    public required INotificationService NotificationService { private get; init; }
    private readonly LlmServiceConfig _configuration;
    private readonly HttpClient _httpClient;
    private readonly string _endpointUrl;
    private readonly string _apiKey;
    private readonly string _modelName;
    private bool disposedValue;

    public JournalService(LlmServiceConfig configuration)
    {
        _configuration = configuration;
        _httpClient = new HttpClient();
        _httpClient.Timeout = TimeSpan.FromMinutes(5);

        // Retrieve LLM settings from configuration
        _endpointUrl =
            _configuration.EndpointUrl
            ?? throw new InvalidOperationException("LlmService:EndpointUrl is not configured.");
        _apiKey =
            _configuration.Jwt
            ?? throw new InvalidOperationException("LlmService:ApiKey is not configured.");
        _modelName = _configuration.Model ?? "gpt-3.5-turbo"; // Default model if not specified

        // Set up HttpClient
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            _apiKey
        );
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

    public required ILogger<JournalService> Log { private get; init; }

    public async Task SaveJournal(string title, string entry)
    {
        await SaveFileToDisk(title, entry);
        var id = await SaveFile(title, entry);
        await SaveKb(id);
    }

    private async Task SaveFileToDisk(string title, string entry)
    {
        try
        {
            if (!FileSystem.Directory.Exists("journals"))
            {
                FileSystem.Directory.CreateDirectory("journals");
            }

            using var file = File.Open($"journals/{title}.txt", FileMode.CreateNew);
            await file.WriteAsync(Encoding.UTF8.GetBytes(entry));
        }
        catch (Exception ex)
        {
            Log.LogError(
                ex,
                "Failed to save journal entry {Title}.txt to disk: {ErrorMessage}",
                title,
                ex.Message
            );
            NotificationService.Notify(
                "Failed to save file",
                $"Failed to save journal entry {title}.txt to disk: {ex.Message}",
                4
            );
        }
    }

    private async Task<string> SaveFile(string title, string entry)
    {
        Log.LogDebug("Saving {Title}", title);

        if (string.IsNullOrEmpty(entry))
        {
            return String.Empty;
        }
        var epuri = $"{_endpointUrl}/api/v1/files/?internal=false&process=true";
        var content = new MultipartFormDataContent();
        var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(entry));
        fileContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
        content.Add(fileContent, "file", $"{title}.txt");
        var response = await _httpClient.PostAsync(epuri, content);
        response.EnsureSuccessStatusCode(); // Throws HttpRequestException for 4xx/5xx status codes

        var responseString = await response.Content.ReadAsStringAsync();
        Log.LogInformation("{Content}", responseString);

        // Parse the JSON response
        using (JsonDocument doc = JsonDocument.Parse(responseString))
        {
            // Navigate to choices[0].message.content
            if (doc.RootElement.TryGetProperty("id", out JsonElement idElement))
            {
                var id = idElement.GetString();

                return id;
            }
        }

        // If we reach here, the response structure was not as expected
        throw new InvalidOperationException(
            $"LLM response did not contain expected 'id'. Full response: {responseString}"
        );
    }

    private async Task<bool> SaveKb(string id)
    {
        var payLoad = $$"""{"file_id": "{{id}}"}""";
        var requestUri =
            $"{_endpointUrl}/api/v1/knowledge/{this._configuration.KnowledgeId}/file/add";

        Log.LogDebug(
            "Sending POST request to add file to KB: {RequestUrl} with payload: {Payload}",
            requestUri,
            payLoad
        );

        using var content = new StringContent(payLoad, Encoding.UTF8, "application/json");
        try
        {
            var response = await _httpClient.PostAsync(requestUri, content);
            response.EnsureSuccessStatusCode(); // Throws HttpRequestException for 4xx/5xx status codes

            var responseString = await response.Content.ReadAsStringAsync();
            Log.LogInformation(
                "Successfully added file to KB. Response: {Response}",
                responseString
            );
            return true;
        }
        catch (HttpRequestException ex)
        {
            Log.LogError(ex, "Error adding file to KB: {Message}", ex.Message);
            return false;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                _httpClient?.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~JournalService()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
