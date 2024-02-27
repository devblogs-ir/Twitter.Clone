namespace Twitter.Clone.Tweet.Infrastructure;
   
using Microsoft.Extensions.DependencyInjection;
using Twitter.Clone.Tweet.Application.Contracts.Repository;
using Twitter.Clone.Tweet.Infrastructure.Repository;  

public static class InfrastructureConfigureServices
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
    {     
        services.AddScoped<ITweetRepository, TweetRepository>();
        return services;
    }
}