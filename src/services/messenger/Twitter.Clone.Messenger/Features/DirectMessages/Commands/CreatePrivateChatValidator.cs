using FluentValidation;

namespace Twitter.Clone.Messenger.Features.DirectMessages.Commands
{
    public class CreatePrivateChatValidator : AbstractValidator<CreatePrivateChat>
    {
        public CreatePrivateChatValidator()
        {
            RuleFor(chat => chat.StarterUserId)
                .NotEmpty().WithMessage("StarterUserId is required");

            RuleFor(chat => chat.TargetUserId)
                .NotEmpty().WithMessage("TargetUserId is required");

            RuleFor(chat => chat.IsForStarter)
                .NotEmpty().WithMessage("IsForStarter is required");

            RuleFor(chat => chat.MessageBody)
                .NotEmpty().WithMessage("MessageBody is required");
                //.MaximumLength()
        }
    }
}
