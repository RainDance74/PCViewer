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

        services.AddTransient<IApplicationRunner, ApplicationRunner>();
    }
}
