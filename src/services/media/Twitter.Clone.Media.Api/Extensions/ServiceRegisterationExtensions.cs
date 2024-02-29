using MassTransit;
using Twitter.Clone.Media.Api.Settings;

namespace Twitter.Clone.Media.Api.Extensions;

public static class ServiceRegisterationExtensions
{
    public static void AddMessageBroker(this WebApplicationBuilder builder)
    {
        var messageBrokerSettings = GetSettings<MessageBrokerSettings>(builder, MessageBrokerSettings.Section);
        var rabbitMqAddress = new Uri(messageBrokerSettings.Url);

        var messageBrokerLoginSettings = GetSettings<MessageBrokerLoginSettings>(builder, MessageBrokerLoginSettings.Section);

        builder.Services.AddMassTransit(configure =>
        {
            // Consumer Registration
            configure.UsingRabbitMq((context, config) =>
            {
                config.Host(rabbitMqAddress, "/", configure =>
                {
                    configure.Username(messageBrokerLoginSettings.Username);
                    configure.Password(messageBrokerLoginSettings.Password);
                });

                config.ConfigureEndpoints(context);
            });
        });
    }

    private static TSettings GetSettings<TSettings>(WebApplicationBuilder builder, string section)
    {
        var messageBrokerLoginSettings = builder.Configuration
                                                .GetSection(section)
                                                .Get<TSettings>();

        if (messageBrokerLoginSettings is null)
        {
            throw new ArgumentException($"{typeof(TSettings).FullName} not found!");
        }

        return messageBrokerLoginSettings;
    }
}
