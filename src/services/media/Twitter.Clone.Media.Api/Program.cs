using Twitter.Clone.Media.Api.Extensions;
using Twitter.Clone.Media.Api.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var messageBrokerLoginSettings = builder.Configuration
                                        .GetSection(MessageBrokerLoginSettings.Section)
                                        .Get<MessageBrokerLoginSettings>();

var messageBrokerSettings = builder.Configuration
                                   .GetSection(MessageBrokerSettings.Section)
                                   .Get<MessageBrokerSettings>();

if (messageBrokerLoginSettings is null)
{
    throw new ArgumentException("Message Broker Credentials not found! Please add them via user-secrets!");
}

if (messageBrokerSettings is null)
{
    throw new ArgumentException("Message Broker Settings not found!");
}

builder.Services.AddMessageBroker(messageBrokerLoginSettings, messageBrokerSettings);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
