namespace Twitter.Clone.Media.Api.Configurations;

public class MessageBrokerLoginSettings
{
    public const string Section = "Secrets:MessageBroker";
    public required string Username { get; set; }
    public required string Password { get; set; }
}
