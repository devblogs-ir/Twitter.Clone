namespace Twitter.Clone.Search.WebApi.Entities;

public class Hashtag
{
    public Guid Id { get; init; }
    public string Title { get; init; }

    public List<TweetHashtag> TweetHashtags { get; } = [];
    public List<Tweet> Tweets { get; } = [] ;

}