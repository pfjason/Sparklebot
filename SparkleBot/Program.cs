using Autofac;
using SparkleBot.DependencyInjection;
using SparkleBot.Interfaces;

namespace SparkleBot;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var rootScope = BuildRootScope(args);
        var sparkle = rootScope.Resolve<ISparkleService>();
        await sparkle.Run();
        return 0;
    }

    public static ILifetimeScope BuildRootScope(string[] args)
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new RootScopeModule(args));
        return builder.Build();
    }
}
