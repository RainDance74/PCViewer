using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCViewer.Contracts.Services;
using PCViewer.Core.Contracts;
using PCViewer.Core.Models;
using PCViewer.Core.Services;
using PCViewer.Services;

namespace PCViewer;
internal class Startup(IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IDataStore<Computer>, DataStore<Computer>>();

        services.AddTransient<ComputerBuilder, MyComputerBuilder>();
        services.AddTransient<LaptopBuilder, MyLaptopBuilder>();

        services.AddSingleton<ILogger, Logger>();
        services.AddSingleton<DebugWriter>(services => 
        {
            var debugWriter = new DebugWriter();
            services.GetRequiredService<ILogger>().OnLog += debugWriter.Write;
            return debugWriter;
        });
        services.AddSingleton<FileWriter>(services =>
        {
            var fileWriter = new FileWriter();
            services.GetRequiredService<ILogger>().OnLog += fileWriter.Write;
            return fileWriter;
        });

        services.AddTransient<IApplicationRunner, ApplicationRunner>();
    }
}
