using MassTransit;
using Twitter.Clone.Media.Api.Settings;

namespace Twitter.Clone.Media.Api.Extensions;

public static class ServiceRegisterationExtensions
{
    public static void AddMessageBroker(this IServiceCollection services, MessageBrokerLoginSettings messageBrokerLoginSetting, MessageBrokerSettings messageBrokerSettings)
    {
        var rabbitMqAddress = new Uri(messageBrokerSettings.Url);

        services.AddMassTransit(configure =>
        {
            // Consumer Registration
            configure.UsingRabbitMq((context, config) =>
            {
                config.Host(rabbitMqAddress, "/", configure =>
                {
                    configure.Username(messageBrokerLoginSetting.Username);
                    configure.Password(messageBrokerLoginSetting.Password);
                });

                config.ConfigureEndpoints(context);
            });
        });
    }
}
