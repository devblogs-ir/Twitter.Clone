namespace Twitter.Clone.Locator.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureServiceDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LocatorDbContext>(options =>
        {
            var conStr = configuration.GetConnectionString(LocatorDbContext.ConnectionStringSectionName);
            options.UseSqlServer(conStr);
        });

        return services;
    }
}
