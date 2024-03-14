using MediatR;
using Twitter.Clone.Messenger.Models;
using Twitter.Clone.Messenger.ServiceManager;
using Twitter.Clone.Messenger.Shared.Enums;

namespace Twitter.Clone.Messenger.Features.PublicMessages;

public static class AddPublicMessageStatus {
    //Input
    public class AddPublicMessageStatusCommand : IRequest<AddPublicMessageStatusResponse>
    {
      
        public long PublicMessageStatusId { get; set; }
        public long PublicMessageId { get; set; }
        public required PublicMessage PublicMessage { get; set; }
        public Guid UserId { get; set; }
        public MessageStatus SentMessageSatus { get; set; }
        public DateTime DeliverDateTime { get; set; }
        public bool IsDeleted { get; set; }
       
    }

    //Output
    public class AddPublicMessageStatusResponse
    {
        public long PublicMessageStatusId { get; set; }
        public long PublicMessageId { get; set; }
        public required PublicMessage PublicMessage { get; set; }
        public Guid UserId { get; set; }
        public MessageStatus SentMessageSatus { get; set; }
        public DateTime DeliverDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }

    internal sealed class Handler : IRequestHandler<AddPublicMessageStatusCommand, AddPublicMessageStatusResponse>
    {
        public Task<AddPublicMessageStatusResponse> Handle(AddPublicMessageStatusCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}