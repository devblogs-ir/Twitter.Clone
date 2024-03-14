namespace Twitter.Clone.Notifier.Host;

public sealed class AppSettings
{
    public required BrokerAppSettings BrokerConfiguration { get; set; }
}


public sealed class BrokerAppSettings
{
    public const string SectionName = "BrokerConfiguration";
    public required string Host { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
}
