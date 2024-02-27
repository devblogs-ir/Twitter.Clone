namespace Twitter.Clone.Tweet.WebApi;
  
using Twitter.Clone.Tweet.Infrastructure.Models;
using Twitter.Clone.Tweet.Application.Contracts.Repository;
using Twitter.Clone.Tweet.Infrastructure.Repository;  

public static class PresentationConfigureServices
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services, IConfiguration configuration)
    {   
        services.Configure<MongoDbConfigurationModel>(configuration.GetSection("MongoDbConfigurations"));   
        return services;
    }
}