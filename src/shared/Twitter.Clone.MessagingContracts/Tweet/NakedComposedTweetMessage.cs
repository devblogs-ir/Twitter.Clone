namespace Twitter.Clone.MessagingContracts.Tweet;

public record NakedComposedTweetMessage(Guid UserId, string Text, DateTime CreatedDate, DateTime? ModifiedDate) : MessageBase;
