using System.IO.Abstractions;
using System.Reflection;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Jobs;
using SparkleBot.Models;
using SparkleBot.Services;
using Path = System.IO.Path;

namespace SparkleBot.DependencyInjection;

public class RootScopeModule(string[] args) : Autofac.Module
{
    private readonly string[] _args = args ?? [];

    protected override void Load(ContainerBuilder builder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.production.json", optional: true)
            .AddEnvironmentVariables()
            .AddCommandLine(_args)
            .Build();

        builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
        builder.RegisterType<GotifyService>().As<INotificationService>().SingleInstance();

        // Configure Serilog
        Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

        // Bind configuration sections to strongly-typed objects and register them
        var mastodonConfig =
            configuration.GetSection("Mastodon").Get<MastodonConfig>() ?? new MastodonConfig();
        builder.RegisterInstance(mastodonConfig).SingleInstance();

        var gotifyConfig =
            configuration.GetSection("Gotify").Get<GotifyConfig>() ?? new GotifyConfig();
        builder.RegisterInstance(gotifyConfig).SingleInstance();

        var sparkleConfig =
            configuration.GetSection("Sparkle").Get<SparkleConfig>() ?? new SparkleConfig();
        builder.RegisterInstance(sparkleConfig).SingleInstance();

        var mqttConfig =
            configuration.GetSection("Mqtt").Get<MqttConfiguration>() ?? new MqttConfiguration();
        builder.RegisterInstance(mqttConfig).SingleInstance();

        var llmConfig =
            configuration.GetSection("LlmService").Get<LlmServiceConfig>()
            ?? new LlmServiceConfig();

        builder.RegisterInstance(llmConfig).SingleInstance();

        builder
            .RegisterType<ScheduledPostJob>()
            .AsSelf()
            .AsImplementedInterfaces()
            .InstancePerDependency();

        // Register Serilog ILoggerFactory
        builder.RegisterType<SerilogLoggerFactory>().As<ILoggerFactory>().SingleInstance();

        // Register ILogger<T>
        builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>)).SingleInstance();

        // Also register ILogger directly if you need a non-generic logger
        builder
            .Register(c => c.Resolve<ILoggerFactory>().CreateLogger("SparkleBot"))
            .As<Microsoft.Extensions.Logging.ILogger>()
            .SingleInstance();

        builder
            .RegisterType<MastodonService>()
            .As<IMastodonService>()
            .SingleInstance()
            .OnActivated(o => o.Instance.StartAsync().GetAwaiter().GetResult());

        builder.RegisterType<LlmService>().As<ILlmService>().SingleInstance();
        builder.RegisterType<JournalService>().As<IJournalService>().SingleInstance();
        builder
            .RegisterType<SparkleService>()
            .As<ISparkleService>()
            .As<IHostedService>()
            .SingleInstance();
        builder.RegisterType<ToolService>().As<IToolService>().SingleInstance();
        builder.RegisterType<MqttService>().As<IMqttService>().SingleInstance()
            .OnActivated(o => o.Instance.StartAsync().GetAwaiter().GetResult())
            .AutoActivate();
        builder.Register(o => new System.IO.Abstractions.FileSystem()).As<IFileSystem>().SingleInstance();

        builder
            .RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(x => x.IsAssignableTo<ITool>())
            .As<ITool>()
            .SingleInstance();
    }
}
