namespace Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;

using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;
using MediatR;

public class CreateTweetCommandHandler : IRequestHandler<CreateTweetCommand, Guid>
{
    public async Task<Guid> Handle(CreateTweetCommand request, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("Test");
        return Guid.NewGuid();
    }
}