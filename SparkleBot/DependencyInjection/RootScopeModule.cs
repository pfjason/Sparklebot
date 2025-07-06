using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Extensions;
using Serilog;
using Serilog.Extensions.Logging;
using SparkleBot.Interfaces;
using SparkleBot.Models;
using SparkleBot.Services;
using Path = System.IO.Path;

namespace SparkleBot.DependencyInjection;

public class RootScopeModule : Autofac.Module
{
    private readonly string[] _args;

    public RootScopeModule(string[] args)
    {
        _args = args ?? Array.Empty<string>();
    }

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

        // Configure Serilog
        Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

        // Bind configuration sections to strongly-typed objects and register them
        var mastodonConfig =
            configuration.GetSection("Mastodon").Get<MastodonConfig>() ?? new MastodonConfig();
        builder.RegisterInstance(mastodonConfig).SingleInstance();

        var llmConfig =
            configuration.GetSection("LlmService").Get<LlmServiceConfig>()
            ?? new LlmServiceConfig();

        builder.RegisterInstance(llmConfig).SingleInstance();

        //builder.RegisterType<HttpClient>().AsSelf().InstancePerDependency();

        var sc = new ServiceCollection();
        sc.AddApi(o =>
        {
            o.AddApiHttpClients(c =>
                {
                    c.BaseAddress = new Uri(llmConfig.EndpointUrl);
                })
                .AddTokens(new BearerToken(llmConfig.Jwt));
        });
        
        builder.Populate(sc);

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
        builder.RegisterType<SparkleService>().As<ISparkleService>().SingleInstance();
    }
}
