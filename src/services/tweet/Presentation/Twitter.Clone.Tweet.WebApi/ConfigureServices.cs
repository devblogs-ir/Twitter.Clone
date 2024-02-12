namespace Twitter.Clone.Tweet.WebApi;
 
using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;
using Twitter.Clone.Tweet.Infrastructure.Persistence.DbContext;
using Twitter.Clone.Tweet.WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MediatR;

public static class ConfigureServices
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Get Settings from appsettings.json
        var _mongoDbConfigurations = configuration.GetSection("MongoDbConfigurations").Get<MongoDbConfigurationModel>();

        // Add Services
        services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(CreateTweetCommand).Assembly));
        services.AddDbContext<TweetDbContext>(options =>
        {
            options.UseMongoDB(
                connectionString: _mongoDbConfigurations.ConnectionString ?? "mongodb://localhost:27017",
                databaseName: _mongoDbConfigurations.DatabaseName ?? "TweetDb"
            );
        });

        return services;
    }
}