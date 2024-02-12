using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


namespace Twitter.Clone.Search.Application;

public static class ConfigureServices
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}
