var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServiceDbContext(builder.Configuration);

var app = builder.Build();

app.Run();



