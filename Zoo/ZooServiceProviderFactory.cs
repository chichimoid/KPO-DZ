namespace Zoo;

using Microsoft.Extensions.DependencyInjection;

public static class ZooServiceProviderFactory
{
    public static IServiceProvider CreateServiceProvider()
    {
        var services = new ServiceCollection();
        
        services.AddSingleton<Zoo>();
        
        services.AddTransient<Clinic>();
        services.AddTransient<RabbitFactory>();
        services.AddTransient<MonkeyFactory>();
        services.AddTransient<TigerFactory>();
        services.AddTransient<WolfFactory>();
        services.AddTransient<ComputerFactory>();
        services.AddTransient<TableFactory>();

        return services.BuildServiceProvider();
    }
}