using FluentValidation;
using Microsoft.AspNetCore.Rewrite;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.GetUnread
{
    public class GetUnreadMessagesValidator : AbstractValidator<GetUnreadMessagesCommand>
    {
        public GetUnreadMessagesValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.UserId).Must(ValidateGuid)
                .WithMessage("UserId is not a valid Guid!");
        }

        private bool ValidateGuid(string val) => Guid.TryParse(val, out _);


    }
}
