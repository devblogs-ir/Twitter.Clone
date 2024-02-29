namespace Twitter.Clone.Media.Api.Settings;

public sealed class MessageBrokerLoginSettings
{
    public const string Section = "Secrets:MessageBroker";
    public required string Username { get; set; }
    public required string Password { get; set; }
}
