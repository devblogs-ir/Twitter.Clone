using MediatR;

namespace Twitter.Clone.Messenger.Features.DirectMessages.Commands
{
    public class CreatePrivateChat : IRequest<long>

    {
        public Guid StarterUserId { get; set; }
        public Guid TargetUserId { get; set; }
        public required string MessageBody { get; set; }
        public bool IsForStarter { get; set; }
    }
}
