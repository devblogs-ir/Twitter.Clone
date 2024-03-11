using Twitter.Clone.Notifier.Host.Extensions;

using Autofac;
using Autofac.Extensions.DependencyInjection;
using Twitter.Clone.Notifier.Common.Autofac;
using Twitter.Clone.Notifier.Features.Sms.Contracts;
using Twitter.Clone.Notifier.Features.Sms.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureBrokerService(builder.Configuration);
builder.Services.ConfigureAppSettings(builder.Configuration);
builder.Services.Configure<SmsProvidersSetting>(builder.Configuration.GetSection(SmsProvidersSetting.SectionName));
builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>((container) =>
    {
        container.AddAutofacDependencyServices();
    });

var app = builder.Build();

app.Run();
