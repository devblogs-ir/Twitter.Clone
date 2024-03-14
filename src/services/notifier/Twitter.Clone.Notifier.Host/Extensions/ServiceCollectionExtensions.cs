using MassTransit;
using Twitter.Clone.Notifier.Host.Exceptions;

namespace Twitter.Clone.Notifier.Host.Extensions;

public static class ServiceCollectionExtensions
{
    

    public static IServiceCollection ConfigureBrokerService(this IServiceCollection services, IConfiguration configuration)
    {
        var settings = configuration.GetSection(BrokerAppSettings.SectionName)
                                    .Get< BrokerAppSettings>();

        if (settings is null)
        { 
            throw new AppSettingsNullReferenceException(nameof(BrokerAppSettings)); 
        }

        services.AddMassTransit(configure => {

            configure.AddConsumers(typeof(Program).Assembly);

            configure.UsingRabbitMq((context, rabbitConfigure) => {

                rabbitConfigure.Host(host: settings.Host, configureHost =>
                {
                    configureHost.Username(settings.Username);
                    configureHost.Password(settings.Password);

                });

                rabbitConfigure.ConfigureEndpoints(context);
            });
        });

        return services;
    }

    public static IServiceCollection ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<AppSettings>(configuration);
        return services;
    }
}
