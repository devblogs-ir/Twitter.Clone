using Autofac;
using Autofac.Extensions.DependencyInjection;
using Twitter.Clone.Notifier.Common.Autofac;
using Twitter.Clone.Notifier.Features.Sms.Contracts;
using Twitter.Clone.Notifier.Features.Sms.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<FarapayamakSetting>(builder.Configuration.GetSection(FarapayamakSetting.SectionName));
builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>((container) =>
    {
        container.AddAutofacDependencyServices();
    });

var app = builder.Build();

app.MapPost("/test", (string text, string mobile
    , ISmsService smsService) =>
{
    smsService.Send(text, mobile);
});
app.Run();
