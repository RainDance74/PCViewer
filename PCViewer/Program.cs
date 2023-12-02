using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PCViewer;
using PCViewer.Contracts.Services;
using PCViewer.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var configuration = CreateConfigurationBuilder(args)
            .Build();
        var serviceProvider = CreateIoCContainer(configuration)
            .BuildServiceProvider();
        var runner = serviceProvider
            .GetRequiredService<IApplicationRunner>();
        runner.Run();
    }

    private static IConfigurationBuilder CreateConfigurationBuilder(string[] args)
    {
        return new ConfigurationBuilder();
    }

    private static IServiceCollection CreateIoCContainer(IConfigurationRoot configuration)
    {
        return new ServiceCollection()
            .UseStartup<Startup>(configuration);
    }
}