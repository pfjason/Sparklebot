using System;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Tools.Mastodon;

public class CreatePostTool : ToolBase
{
    #region Property Injections
    public required ILogger<CreatePostTool> Log { private get; init; }
    public required IMastodonService Mastodon { private get; init; }
    #endregion
    public override string Prompt => "Creates a new Mastodon post";

    public override string Name => "mastodon_create_post";

    public override IEnumerable<Parameter> Parameters =>
        new List<Parameter>()
        {
            new()
            {
                Name = "content",
                PromptDescription = "The content of the post to be created",
                Type = ParameterType.String
            },
            new()
            {
                Name = "visibility",
                PromptDescription =
                    $"Visibility setting for the post. Valid values are [{String.Join(',', Enum.GetNames(typeof(Mastonet.Visibility)))}]",
                Type = ParameterType.String
            }
        };

    public override async Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        if (
            TryGetParameter("content", parameters, out var content)
            && TryGetParameter("visibility", parameters, out var visString)
            && Enum.TryParse<Mastonet.Visibility>(visString?.ToString(), true, out var visibility)
        )
        {
            Log.LogInformation(
                "The Mastodon Create Post Tool was called with content: {Content}",
                content
            );
            try
            {
                var result = await Mastodon.PostStatusAsync(content.ToString(), visibility);

                if (result == null)
                {
                    return new ToolResponse()
                    {
                        Success = false,
                        Result = $"Post was not created.",
                        ToolName = Name
                    };
                }

                return new ToolResponse()
                {
                    Success = true,
                    Result = $"Post was successfully created with content: {content}",
                    ToolName = Name
                };
            }
            catch (Exception ex)
            {
                var error = $"Mastodon Create Post tool failed with error: {ex.Message}";
                Log.LogWarning(ex, error);
                return new ToolResponse()
                {
                    Success = false,
                    Result = error,
                    ToolName = Name
                };
            }
        }
        else
        {
            return new ToolResponse()
            {
                Result =
                    $"ERROR: content or visibility parameter was missing or unparsable from the call to {this.Name}",
                Success = false,
                ToolName = this.Name
            };
        }
    }
}
