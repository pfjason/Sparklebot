using Autofac;
using Autofac.Extensions.DependencyInjection;
using Hangfire;
using SparkleBot.DependencyInjection;
using SparkleBot.Interfaces;
using SparkleBot.Jobs;
using SparkleBot.Models;
using SparkleBot.WebUI.Components;

namespace SparkleBot.WebUI;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var rootScope = SparkleBot.Program.BuildRootScope(args);
        Setup(rootScope);

        builder.Host.UseServiceProviderFactory(
            new AutofacChildLifetimeScopeServiceProviderFactory(() => rootScope)
        );

        builder.Host.ConfigureContainer<AutofacChildLifetimeScopeConfigurationAdapter>(adapter =>
        {
            adapter.Add(builder => { });
        });

        // Add services to the container.
        builder.Services.AddRazorComponents().AddInteractiveServerComponents();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
        
         using var hf = new BackgroundJobServer();
        app.Run();
    }

    public static void Setup(ILifetimeScope rootScope)
    {
        GlobalConfiguration.Configuration.UseAutofacActivator(rootScope, false);
        GlobalConfiguration.Configuration.UseInMemoryStorage();
        var sparkle = rootScope.Resolve<ISparkleService>();
        var sparkleConfig = rootScope.Resolve<SparkleConfig>();
       
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
    }
}
