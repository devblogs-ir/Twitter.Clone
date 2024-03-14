using Twitter.Clone.Messenger.ServiceManager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

builder.Services.AddScoped<IServiceManager, ServiceManager>();


var app = builder.Build();

app.Run();
