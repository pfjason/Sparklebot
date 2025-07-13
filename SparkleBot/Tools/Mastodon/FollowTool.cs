using System;
using Mastonet.Entities;
using Microsoft.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;

namespace SparkleBot.Tools.Mastodon;

public class FollowTool : ToolBase
{
    #region Property Injections

    public required IMastodonService Mastodon { private get; init; }
    public required ILogger<FollowTool> Log { private get; init; }

    #endregion

    public override string Prompt => "Starts following a user on Mastodon";

    public override string Name => "mastodon_follow";

    public override IEnumerable<Parameter> Parameters { get; } =
        new List<Parameter>()
        {
            new()
            {
                Name = "accountId",
                PromptDescription = "Username or user id of the account to follow.",
                Type = ParameterType.String
            }
        };

    public override async Task<ToolResponse> Execute(IDictionary<string, object> parameters)
    {
        if (TryGetParameter("accountId", parameters, out var userParam))
        {
            Log.LogInformation(
                "The Mastodon Follow Tool was called with user: {AccountId}",
                userParam
            );
            try
            {
                var followed = await Mastodon.FollowAccountAsync(userParam?.ToString());
                if (followed == null)
                {
                    return new ToolResponse()
                    {
                        Success = false,
                        Result = $"User {userParam} was not found",
                        ToolName = Name
                    };
                }

                return new ToolResponse()
                {
                    Success = true,
                    Result = $"User {followed.UserName} has been successfully followed",
                    ToolName = Name
                };
            }
            catch (Exception ex)
            {
                var error = $"Mastodon Follow tool failed with error: {ex.Message}";
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
                Result = $"ERROR: accountId parameter was missing from the call to {this.Name}",
                Success = false,
                ToolName = this.Name
            };
        }
    }
}
