using MassTransit;
using Twitter.Clone.Media.Api.Configurations;

namespace Twitter.Clone.Media.Api.Extensions;

public static class ServiceRegisterationExtensions
{
    public static void AddMessageBroker(this IServiceCollection services)
    {
        var rabbitMqAddress = new Uri("amqp://localhost:5672");

        services.AddMassTransit(configure =>
        {
            // Consumer Registration
            configure.UsingRabbitMq((context, config) =>
            {
                config.Host(rabbitMqAddress, "/", configure =>
                {
                    configure.Username("guest");
                    configure.Password("guest");
                });

                config.ConfigureEndpoints(context);
            });
        });
    }
}
