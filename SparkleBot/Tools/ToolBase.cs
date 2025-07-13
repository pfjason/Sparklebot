using System;
using SparkleBot.Models;

namespace SparkleBot.Tools;

public abstract class ToolBase : ITool
{
    public virtual bool Enabled { get; set; } = true;
    public abstract string Prompt { get; }
    public abstract string Name { get; }
    public abstract IEnumerable<Parameter> Parameters { get; }

    public abstract Task<ToolResponse> Execute(IDictionary<string, object> parameters);

    protected bool TryGetParameter(
        string parameter,
        IDictionary<string, object> parameters,
        out object value
    )
    {
        var msgParam = parameters.FirstOrDefault(k =>
            k.Key.Equals(parameter, StringComparison.InvariantCultureIgnoreCase)
        );

        if (String.IsNullOrWhiteSpace(msgParam.Key))
        {
            value = "NOT FOUND";
            return false;
        }
        value = msgParam.Value;
        return true;
    }
}
