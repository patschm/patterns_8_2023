using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shapes;


namespace DrawNotSoPerfect;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        var host = CreateHostBuilder().Build();
        Application.Run(host.Services.GetRequiredService<DrawMain>());
    }
    
    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            //.ConfigureAppConfiguration((ctx, cf) => {
            //    cf.AddJsonFile($"appsettings.{ctx.HostingEnvironment.EnvironmentName}.json");
            //})
            .ConfigureLogging(bld =>
            {
                bld.ClearProviders();
                bld.AddDebug();
            })
            .ConfigureServices((ctx, services) => {
                services.AddTransient<DrawMain>();
                services.AddSingleton<IStorage, LocalFileStorage>();
            });
    }
}