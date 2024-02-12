namespace Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;

using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;
using Twitter.Clone.Tweet.Application.Contracts.Repository;
using Twitter.Clone.Tweet.Domain.Entities;
using MediatR;

public class CreateTweetCommandHandler(ITweetRepository tweetRepository) : IRequestHandler<CreateTweetCommand, Guid>
{ 
    private readonly ITweetRepository _tweetRepository = tweetRepository;

    public async Task<Guid> Handle(CreateTweetCommand request, CancellationToken cancellationToken = default)
    {
        var newentity = new TweetEntity
        {
            Id = Guid.NewGuid(),
            Text = request.Text,
            CreatedDate = DateTime.UtcNow,
            UserId = Guid.NewGuid()
        };

        await _tweetRepository.CreateAsync(newentity);
        return newentity.Id;
    }
}