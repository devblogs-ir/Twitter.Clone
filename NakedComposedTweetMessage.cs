namespace Twitter.Clone.MessagingContracts.Tweet;

public record NakedComposedTweetMessage(string UserId, string Text, string CreatedDate, string ModifiedDate) : MessageBase;
