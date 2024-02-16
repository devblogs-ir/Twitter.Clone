namespace Twitter.Clone.Search.WebApi.Entities;

public class TweetHashtag
{
    public Guid TweetId { get; set; }
    public Tweet Tweet { get; set; } = null!;

    public Guid HashtagId { get; set; }
    public Hashtag Hashtag { get; set; } = null!;
}
