namespace Twitter.Clone.MessagingContracts.Notifier;

public record MentionMessage(long UserId ,long ReciverId,string Title ,string Description ) : MessageBase;
