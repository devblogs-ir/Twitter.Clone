namespace Twitter.Clone.Tweet.Domain.Entities;

public class TweetEntity
{ 
    public Guid Id { get; set; }  
    public Guid UserId { get; set; } 
    public string Text { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}