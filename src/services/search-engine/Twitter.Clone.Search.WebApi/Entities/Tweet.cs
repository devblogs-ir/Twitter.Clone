namespace Twitter.Clone.Search.WebApi.Entities;

public class Tweet
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }

    public string Content { get; set; }
    public int LikeCount { get; set; }
    public DateTime CreationDate { get; set; }
    public int RetweetCount { get; set; }

    public List<TweetHashtag> TweetHashtags { get; set; } = [];
    public List<Hashtag> Hashtags { get; set; } = [];

}
