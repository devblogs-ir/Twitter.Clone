namespace Twitter.Clone.MessagingContracts.Abstractions;

public abstract record class MessageBase
{
    public DateTime OccurredOn { get; set; } = DateTime.UtcNow;
}
