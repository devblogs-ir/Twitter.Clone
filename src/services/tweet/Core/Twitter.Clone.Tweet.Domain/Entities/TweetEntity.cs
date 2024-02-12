namespace Twitter.Clone.Tweet.Domain.Entities;

public class TweetEntity
{  
    public TweetEntity(string text)
    {
        Id = Guid.NewGuid();
        Text = text;
        CreatedDate = DateTime.Now;
        UserId = Guid.NewGuid();
    }

    public Guid Id { get; private set; }  
    public Guid UserId { get; private set; } 
    public string Text { get; set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime? ModifiedDate { get; private set; }
}