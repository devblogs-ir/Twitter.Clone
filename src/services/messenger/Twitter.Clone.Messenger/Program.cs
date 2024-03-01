using FluentValidation;
using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Twitter.Clone.Messenger.Common.Behaviours;

using Twitter.Clone.Messenger.ServiceManager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MessengerDbContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("MessengerDbContext")));


var assembly = typeof(Program).Assembly;
builder.Services.AddValidatorsFromAssembly(assembly);
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

builder.Services.AddScoped<IServiceManager, ServiceManager>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.MapControllers();
app.Run();
