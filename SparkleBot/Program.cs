using Autofac;
using Hangfire;
using SparkleBot.DependencyInjection;
using SparkleBot.Interfaces;
using SparkleBot.Jobs;
using SparkleBot.Models;

namespace SparkleBot;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var rootScope = BuildRootScope(args);
        GlobalConfiguration.Configuration.UseAutofacActivator(rootScope, false);
        GlobalConfiguration.Configuration.UseInMemoryStorage();
        var sparkle = rootScope.Resolve<ISparkleService>();
        var sparkleConfig = rootScope.Resolve<SparkleConfig>();
        using var hf = new BackgroundJobServer();
        RecurringJob.AddOrUpdate<ScheduledPostJob>(
            "scheduled-post-job",
            job => job.ExecuteAsync(),
            sparkleConfig.PostSchedule,
            new RecurringJobOptions()
            {
                TimeZone = TimeZoneInfo.Local,
                MisfireHandling = MisfireHandlingMode.Ignorable
            }
        );

        await sparkle.RunAndWait();
        return 0;
    }

    public static ILifetimeScope BuildRootScope(string[] args)
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new RootScopeModule(args));
        return builder.Build();
    }
}
