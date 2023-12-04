using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCViewer.Contracts.Services;
using PCViewer.Services;

namespace PCViewer;
internal class Startup(IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IApplicationRunner, ApplicationRunner>();
        services.AddTransient<ComputerBuilder, MyComputerBuilder>();
        services.AddTransient<LaptopBuilder, MyLaptopBuilder>();
    }
}
