namespace Twitter.Clone.Tweet.Application;
 
using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;  
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation; 
using MediatR;

public static class ApplicationConfigureServices
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {  
        services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(CreateTweetCommand).Assembly)); 
        services.AddValidatorsFromAssemblyContaining(typeof(CreateTweetCommandValidator));
        services.AddScoped<IValidator<CreateTweetCommand>, CreateTweetCommandValidator>();
        return services;
    }
}