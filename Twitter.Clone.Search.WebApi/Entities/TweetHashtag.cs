namespace Twitter.Clone.Search.WebApi.Entities;

public class TweetHashtag
{
    public Guid TweetId { get; init; }
    public Tweet Tweet { get; set; } = null!;

    public Guid HashtagId { get; init; }
    public Hashtag Hashtag { get; set; } = null!;
}
