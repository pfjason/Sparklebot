using Autofac;
using Hangfire;
using Hangfire.InMemory;
using Hangfire.Server;
using Microsoft.Extensions.Hosting;
using SparkleBot.DependencyInjection;
using SparkleBot.Interfaces;
using SparkleBot.Jobs;

namespace SparkleBot;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var rootScope = BuildRootScope(args);
        GlobalConfiguration.Configuration.UseAutofacActivator(rootScope, false);
        GlobalConfiguration.Configuration.UseInMemoryStorage();
        var sparkle = rootScope.Resolve<ISparkleService>();
        using var hf = new BackgroundJobServer();
        RecurringJob.AddOrUpdate<DailyPostJob>(
            "daily-post-job",
            job => job.ExecuteAsync(),
            "0 14 * * *",
            new RecurringJobOptions()
            {
                TimeZone = TimeZoneInfo.Local,
                MisfireHandling = MisfireHandlingMode.Ignorable
            }
        );

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
