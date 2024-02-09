using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Twitter.Clone.IdentityPrvider.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(i =>
            i.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        return services;
    }
}
