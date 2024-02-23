var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureBrokerService(builder.Configuration);
builder.Services.ConfigureAppSettings(builder.Configuration);

var app = builder.Build();

app.Run();
