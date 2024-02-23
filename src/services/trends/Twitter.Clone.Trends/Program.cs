var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureBrokerService(builder.Configuration);
builder.Services.ConfigureAppSettings(builder.Configuration);
builder.Services.ConfigureServiceDbContext(builder.Configuration);
 
var app = builder.Build();

app.MapGet("/sms", (IBus a) => { a.Publish(new NakedHashTagMessage("", "")); });

app.Run();
