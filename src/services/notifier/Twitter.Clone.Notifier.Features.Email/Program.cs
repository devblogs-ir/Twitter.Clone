using Twitter.Clone.Notifier.Features.Email.Configuration;
//using MailKit;
using Microsoft.AspNetCore.Mvc;
using Twitter.Clone.Notifier.Features.Email.Data;
using Twitter.Clone.Notifier.Features.Email.Interfaces;
using Twitter.Clone.Notifier.Features.Email.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

builder.Services.AddTransient<IMailService, MailService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/email", ([FromBody] MailData mailData,
    [FromServices] IMailService mailService) =>
{ 
    return mailService.SendEmail(mailData);        
});


    app.UseSwagger(x => x.SerializeAsV2 = true);
    app.UseSwaggerUI();


app.Run();
