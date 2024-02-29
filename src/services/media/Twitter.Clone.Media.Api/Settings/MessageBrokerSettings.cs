namespace Twitter.Clone.Media.Api.Settings;

public sealed class MessageBrokerSettings
{
    public const string Section = "MessageBroker";
    public required string Url { get; set; }
}
