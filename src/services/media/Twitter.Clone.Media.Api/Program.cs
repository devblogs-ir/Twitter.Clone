using Twitter.Clone.Media.Api.Configurations;
using Twitter.Clone.Media.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var messageBrokerLoginSetting = builder.Configuration
                                       .GetSection(MessageBrokerLoginSettings.Section)
                                       .Get<MessageBrokerLoginSettings>();
if (messageBrokerLoginSetting is null)
{
    throw new ArgumentException("Message Broker Credentials not found! Please add them via user-secrets!");
}

builder.Services.AddMessageBroker(messageBrokerLoginSetting);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
