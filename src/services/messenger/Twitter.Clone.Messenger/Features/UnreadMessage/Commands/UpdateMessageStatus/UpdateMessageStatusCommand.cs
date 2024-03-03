using MediatR;
using Twitter.Clone.Messenger.Shared.Enums;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.UpdateMessageStatus
{
    public class UpdateMessageStatusCommand : IRequest
    {
        public required IEnumerable<long> MessageIds { get; set; }
        public MessageStatus MessageStatus { get; set; }
    }


}
