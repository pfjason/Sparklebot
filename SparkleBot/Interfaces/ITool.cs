using SparkleBot.Models;

public interface ITool
{
    public bool Enabled { get; set; }
    public string Prompt { get; }
    public string Name { get; }
    public IEnumerable<Parameter> Parameters { get; }

    public Task<ToolResponse> Execute(IDictionary<string, object> parameters);
}