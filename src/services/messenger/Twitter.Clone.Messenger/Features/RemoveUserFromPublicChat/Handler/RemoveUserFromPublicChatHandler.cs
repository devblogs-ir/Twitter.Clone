using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Command;

namespace Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Handler
{
    public class RemoveUserFromPublicChatHandler : IRequestHandler<RemoveUserFromPublicChatCommand, RemoveModelDTO>
    {
        MessengerDbContext _db;
        public RemoveUserFromPublicChatHandler(MessengerDbContext db)
        {
            _db = db;
        }

        public async Task<RemoveModelDTO> Handle(RemoveUserFromPublicChatCommand request, CancellationToken cancellationToken)
        {
            var relatedPublicChat =await _db.PublicChats.FirstOrDefaultAsync(pc => pc.ChatId == request.ModelDTO.PublicChatId);
           
            if (relatedPublicChat is not null && relatedPublicChat.Participants.Any(p => p.UserId == request.ModelDTO.UserId))
            {
                var user = relatedPublicChat.Participants.FirstOrDefault(p => p.UserId == request.ModelDTO.UserId);
                if (user is not null)
                {
                    try
                    {
                        relatedPublicChat.Participants.Remove(user);
                        _db.SaveChanges();
                        request.ModelDTO.OperationResult = true;
                        request.ModelDTO.ApplicationFeedBack = "The User Successfully Removed .";
                    }
                    catch (Exception ex)
                    {
                        request.ModelDTO.OperationResult = false;
                        request.ModelDTO.ApplicationFeedBack = ex.Message;
                    }
                }
            }
            return request.ModelDTO;
        }
    }
}
