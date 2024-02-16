using Twitter.Clone.Search.WebApi.Context;

namespace Twitter.Clone.Search.WebApi;

public static class ConfigureServices
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();

        return services;
    }
}
