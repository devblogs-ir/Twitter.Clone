using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Search.WebApi.Context;

namespace Twitter.Clone.Search.WebApi.DI;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services , IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("DefultConnection")));

        return services;
    }
}
