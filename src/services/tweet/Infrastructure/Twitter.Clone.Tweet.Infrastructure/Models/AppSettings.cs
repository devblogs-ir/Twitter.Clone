namespace Twitter.Clone.Tweet.Infrastructure;

public sealed class AppSettings
{
    public required BrokerAppSettings BrokerConfiguration { get; set; }
    public required MongoDbAppSettings MongoDbConfiguration { get; set; }
}
