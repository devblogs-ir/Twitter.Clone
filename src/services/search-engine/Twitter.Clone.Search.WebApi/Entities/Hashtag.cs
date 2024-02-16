namespace Twitter.Clone.Search.WebApi.Entities;

public class Hashtag
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public List<TweetHashtag> TweetHashtags { get; set; } = [];
    public List<Tweet> Tweets { get; set; } = [] ;

}