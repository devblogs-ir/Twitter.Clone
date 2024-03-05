using MediatR; 
using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;
using Twitter.Clone.Tweet.Application;
using Twitter.Clone.Tweet.Infrastructure;
using Twitter.Clone.Tweet.WebApi;
using Twitter.Clone.Tweet.Infrastructure.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterApplicationServices();
builder.Services.RegisterInfrastructureServices();
builder.Services.RegisterPresentationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection(); 
app.MapPost("/tweet", async (CreateTweetCommand command, IMediator mediator) =>
    {
        var result = await mediator.Send(command);

        var response = new ApiResult<Guid> {
            Data = result,
            Successful = true
        };
        return response;
    })
    .WithOpenApi();
app.UseMiddleware<ExceptionMiddleware>();
app.Run();