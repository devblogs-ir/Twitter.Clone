namespace Twitter.Clone.Tweet.WebApi;
 
using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet; 
using Twitter.Clone.Tweet.Infrastructure.Models;
using Twitter.Clone.Tweet.Application.Contracts.Repository;
using Twitter.Clone.Tweet.Infrastructure.Repository; 
using System.Reflection;
using MediatR;

public static class ConfigureServices
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services, IConfiguration configuration)
    {  
        services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(CreateTweetCommand).Assembly)); 
        services.Configure<MongoDbConfigurationModel>(configuration.GetSection("MongoDbConfigurations"));  
        services.AddScoped<ITweetRepository, TweetRepository>();
        return services;
    }
}