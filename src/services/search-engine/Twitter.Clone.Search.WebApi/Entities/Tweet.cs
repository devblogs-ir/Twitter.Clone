namespace Twitter.Clone.Search.WebApi.Entities;

public class Tweet
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }

    public string Content { get; init; }
    public int LikeCount { get; init; }
    public DateTime CreationDate { get; init; }
    public int RetweetCount { get; init; }

    public List<TweetHashtag> TweetHashtags { get;  } = [];
    public List<Hashtag> Hashtags { get; } = [];

}
