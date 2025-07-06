using System.Text.Json.Serialization;

namespace SparkleBot.Models;

public enum Role {

    [JsonStringEnumMemberName("system")]
    System,
    [JsonStringEnumMemberName("user")]
    User,
    [JsonStringEnumMemberName("assistant")]
    Assistant
}