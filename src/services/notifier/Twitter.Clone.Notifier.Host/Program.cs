using Twitter.Clone.Notifier.Features.Sms.Settings;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
builder.Services.Configure<FarapayamakSetting>(builder.Configuration.GetSection(FarapayamakSetting.SectionName));

app.Run();
