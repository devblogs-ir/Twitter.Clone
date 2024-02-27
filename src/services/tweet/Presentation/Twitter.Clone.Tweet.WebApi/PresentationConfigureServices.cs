namespace Twitter.Clone.Tweet.WebApi;
  
using MassTransit;
using Twitter.Clone.Tweet.Infrastructure;

public static class PresentationConfigureServices
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbAppSettings>(configuration.GetSection(MongoDbAppSettings.SectionName));

        var settings = configuration.GetSection(BrokerAppSettings.SectionName).Get<BrokerAppSettings>();
        services.AddMassTransit(configure =>
        {
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