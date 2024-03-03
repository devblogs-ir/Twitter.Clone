using FluentValidation;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.UpdateMessageStatus
{
    public class UpdateMessageStatusValidator : AbstractValidator<UpdateMessageStatusCommand>
    {
        public UpdateMessageStatusValidator()
        {
            RuleFor(x => x.MessageIds).NotNull().NotEmpty();
            RuleFor(x => x.MessageStatus).NotEmpty();
           

        }
    }
}
