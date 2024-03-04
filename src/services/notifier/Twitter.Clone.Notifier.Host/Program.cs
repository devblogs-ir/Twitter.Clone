using Autofac;
using Autofac.Extensions.DependencyInjection;
using Twitter.Clone.Notifier.Common.Autofac;
using Twitter.Clone.Notifier.Features.Sms.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>((container) =>
    {
        container.AddAutofacDependencyServices();
    });

var app = builder.Build();

app.Run();
