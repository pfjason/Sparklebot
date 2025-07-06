using System;

namespace SparkleBot.Models;
#nullable disable
public class SparklePost
{
    public string Id { get; set; }
    public DateTime TimeStamp { get; set; }
    public string Account { get; set; }

    public string Content { get; set; }

    public string ReplyToId { get; set; }
}
