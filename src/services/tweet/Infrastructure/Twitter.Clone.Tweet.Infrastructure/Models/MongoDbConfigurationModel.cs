namespace Twitter.Clone.Tweet.Infrastructure.Models;

public class MongoDbConfigurationModel{
    public string? ConnectionString { get; set; }
    public string? DatabaseName { get; set; }
    public string? CollectionName { get; set; }
}