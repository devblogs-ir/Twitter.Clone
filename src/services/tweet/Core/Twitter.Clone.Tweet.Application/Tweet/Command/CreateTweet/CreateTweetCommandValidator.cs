namespace Twitter.Clone.Tweet.Application.Tweet.Command.CreateTweet;

using FluentValidation;

public class CreateTweetCommandValidator : AbstractValidator<CreateTweetCommand>
{
		public CreateTweetCommandValidator()
		{
            RuleFor(x => x.Text).NotNull().WithMessage("Tweet text is Required");
            RuleFor(x => x.Text).NotEmpty().WithMessage("Tweet text is Required");
            RuleFor(x => x.Text).MaximumLength(400).WithMessage("Tweet text must be 250 chars or fewer");
		}
}