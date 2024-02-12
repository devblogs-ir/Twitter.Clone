using Microsoft.Extensions.DependencyInjection;

namespace Twitter.Clone.Search.Infrastracture;
public static class ConfigureServices
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();

        return services;
    }
}
