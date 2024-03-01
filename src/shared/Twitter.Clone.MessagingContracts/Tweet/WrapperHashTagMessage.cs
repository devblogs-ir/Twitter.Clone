namespace Twitter.Clone.MessagingContracts.Tweet;

public record  WrapperHashTagMessage(List<string> Hashtags, string IP): MessageBase;