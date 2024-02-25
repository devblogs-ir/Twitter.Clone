namespace Twitter.Clone.Tweet.WebApi;
  
using Twitter.Clone.Tweet.Infrastructure.Models;

public static class PresentationConfigureServices
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services, IConfiguration configuration)
    {   
        services.Configure<MongoDbConfigurationModel>(configuration.GetSection("MongoDbConfigurations"));   
        return services;
    }

    public static IServiceCollection ConfigureBrokerService(this IServiceCollection services, IConfiguration configuration)
    {
        var settings = configuration.GetSection(BrokerAppSettings.SectionName).Get<BrokerAppSettings>();

        if (settings is null)
        {
            throw new AppSettingsNullReferenceException(nameof(BrokerAppSettings));
        }

        services.AddMassTransit(configure =>
        {
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
}