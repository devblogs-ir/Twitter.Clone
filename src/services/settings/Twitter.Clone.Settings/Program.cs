using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Context;
using Twitter.Clone.Settings.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGrpc();

builder.Services.AddDbContext<SettingsDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("SettingsConnectionString")));

var app = builder.Build();

app.MapGrpcService<NotificationService>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
