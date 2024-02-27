
namespace Twitter.Clone.Tweet.Infrastructure.Repository;

using Twitter.Clone.Tweet.Application.Contracts.Repository;
using Twitter.Clone.Tweet.Domain.Entities;
using Microsoft.Extensions.Options; 
using MongoDB.Driver;
using MongoDB.Bson;

public class TweetRepository : ITweetRepository
{
    private readonly IMongoCollection<TweetEntity> _tweetCollection;
 
    public TweetRepository(IOptions<MongoDbAppSettings> mongoDBSettings)
    { 
        var _mongoDbClient = new MongoClient(mongoDBSettings.Value.ConnectionString);
        var _database = _mongoDbClient.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _tweetCollection = _database.GetCollection<TweetEntity>(mongoDBSettings.Value.CollectionName);
    } 

    public async Task CreateAsync(TweetEntity entity)
    {   
        await _tweetCollection.InsertOneAsync(entity); 
    }
}