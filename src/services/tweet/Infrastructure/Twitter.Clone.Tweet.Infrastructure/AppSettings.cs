namespace Twitter.Clone.Tweet.Infrastructure;

public sealed class AppSettings
{
    public required BrokerAppSettings BrokerConfiguration { get; set; }
    public required MongoDbAppSettings MongoDbConfiguration { get; set; }
}


public sealed class BrokerAppSettings
{
    public const string SectionName = "BrokerConfiguration";
    public required string Host { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
}

public class MongoDbAppSettings
{
    public const string SectionName = "MongoDbConfigurations";
    public string? ConnectionString { get; set; }
    public string? DatabaseName { get; set; }
    public string? CollectionName { get; set; }
}
