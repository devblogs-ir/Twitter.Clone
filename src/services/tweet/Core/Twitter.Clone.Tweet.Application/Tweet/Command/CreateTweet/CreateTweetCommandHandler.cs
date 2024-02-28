namespace Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;

using Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;
using Twitter.Clone.Tweet.Application.Contracts.Repository;
using Twitter.Clone.Tweet.Domain.Entities;
using FluentValidation;
using MediatR;
using Twitter.Clone.MessagingContracts.Tweet;
using MassTransit;



public class CreateTweetCommandHandler(ITweetRepository tweetRepository, IValidator<CreateTweetCommand> validator, IBus bus) : IRequestHandler<CreateTweetCommand, Guid>
{ 
    private readonly ITweetRepository _tweetRepository = tweetRepository;
    private readonly IValidator<CreateTweetCommand> _validator = validator;
    private readonly IBus _bus = bus;

    public async Task<Guid> Handle(CreateTweetCommand request, CancellationToken cancellationToken = default)
    {
        var validateResult = await _validator.ValidateAsync(request);
        if (!validateResult.IsValid)
            throw new Exception(validateResult.Errors.FirstOrDefault().ErrorMessage);

        var newentity = new TweetEntity(request.Text);
        await _tweetRepository.CreateAsync(newentity);
        var composedMessage = new NakedComposedTweetMessage(
            newentity.UserId, newentity.Text, newentity.CreatedDate, newentity.ModifiedDate);

        await bus.Publish(composedMessage);
        return newentity.Id;
    }
}