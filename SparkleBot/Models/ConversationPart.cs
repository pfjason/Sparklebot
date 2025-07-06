using System.Text.Json.Serialization;

namespace SparkleBot.Models;

public class ConversationPart
{
    public Role Role { get; set; } = Role.User;
    public string? Content { get; set; }
}
