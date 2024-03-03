using MediatR;
using Twitter.Clone.Messenger.Models;
using Twitter.Clone.Messenger.ServiceManager;
using Twitter.Clone.Messenger.Shared.Enums;

namespace Twitter.Clone.Messenger.Features.PublicMessages;

public static class SendMessageToGroup {
    //Input
    public class AddMessageToGroupCommand : IRequest<AddMessageToGroupCommand>
    {
      
        public required string MessageBody { get; set; }
        public Guid MessageOwner { get; set; }
        public DateTime SentDateTime { get; set; }
        public bool IsEdited { get; set; }
        public Guid ChatId { get; set; }
       
    }

    

    internal sealed class Handler : IRequestHandler<AddMessageToGroupCommand, AddMessageToGroupCommand>
    {
        private readonly IServiceManager _serviceManager;
        public Handler(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            
        }
        public async Task<AddMessageToGroupCommand> Handle(AddMessageToGroupCommand request, CancellationToken cancellationToken)
        {
            var publicChatItem = await _serviceManager.PublicMessageService.GetPublicChatItemAsync(request.ChatId);
            var publicMessageId = Guid.NewGuid();
            var publicMessage = new PublicMessage
            {

                Id=publicMessageId,
                MessageBody = request.MessageBody,
                Participants = [],
                PublicChat = publicChatItem!,
                ChatId = request.ChatId,
                IsEdited = false,
                MessageOwner = request.MessageOwner

            };

       
            var listMessageStatus= new List<PublicMessageStatus>();
            listMessageStatus.Add(new PublicMessageStatus
            {
                SentMessageSatus = MessageStatus.Sent,
                IsDeleted = false,
                UserId = request.MessageOwner,
                PublicMessageId = publicMessageId,
                DeliverDateTime = new DateTime(),


            });
            publicMessage.ParticipantStatus = listMessageStatus;
            var resAddToGroupMessage = await _serviceManager.PublicMessageService.SendMessageToGroup(publicMessage);
            if(!resAddToGroupMessage)
                throw new NotImplementedException();

            await _serviceManager.SaveAsync();

            
            return request;
        }
    }
}