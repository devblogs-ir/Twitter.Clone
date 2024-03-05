namespace Twitter.Clone.Tweet.Infrastructure;

public class MongoDbAppSettings
{
    public const string SectionName = "MongoDbConfigurations";
    public string? ConnectionString { get; set; }
    public string? DatabaseName { get; set; }
    public string? CollectionName { get; set; }
}