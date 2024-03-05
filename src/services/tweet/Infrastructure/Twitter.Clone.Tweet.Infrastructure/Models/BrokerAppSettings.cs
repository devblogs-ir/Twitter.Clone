namespace Twitter.Clone.Tweet.Infrastructure;

public sealed class BrokerAppSettings
{
    public const string SectionName = "BrokerConfiguration";
    public required string Host { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
}