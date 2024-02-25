using Twitter.Clone.MessagingContracts.Abstractions;

namespace Twitter.Clone.MessagingContracts.Tweet;

public record NakedComposedTweetMessage(
    Guid UserId, string Text, DateTime? ModifiedDate) : MessageBase;
