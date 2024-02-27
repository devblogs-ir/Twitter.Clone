namespace Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;

using MediatR;

public class CreateTweetCommand : IRequest<Guid> 
{ 
    public string Text { get; set; } 
}