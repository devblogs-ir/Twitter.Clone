using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Command;
using Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Exceptions;
using Twitter.Clone.Messenger.Models;

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
            var relatedPublicChat = await _db.PublicChats.Include(x => x.Participants).
                FirstOrDefaultAsync(pc => pc.ChatId == request.ModelDTO.PublicChatId) ?? throw new NullReferenceException();

            var intendToRemoveParticipant = relatedPublicChat.Participants.
                FirstOrDefault(x => x.UserId == request.ModelDTO.IntendToRemoveUserId) ??
                throw new UserIsNotMemberOfChatException();

            var removerParticipant = relatedPublicChat.Participants.
                FirstOrDefault(x => x.UserId == GetCurrentUserId()) ??
                throw new UserIsNotMemberOfChatException();
            try
            {
                CanRemoveUserFromPublicChat(relatedPublicChat, removerParticipant, intendToRemoveParticipant);
                relatedPublicChat.Participants.Remove(intendToRemoveParticipant);
                _db.SaveChanges();
                request.ModelDTO.OperationResult = true;
                request.ModelDTO.ApplicationFeedBack = "The User Successfully Removed .";
            }
            catch (Exception ex)
            {
                request.ModelDTO.OperationResult = false;
                request.ModelDTO.ApplicationFeedBack = ex.Message;
            }

            return request.ModelDTO;
        }

        bool CanRemoveUserFromPublicChat(PublicChat publicChat, Participant removerParticipant, Participant intendToRemoveParticipant)
        {
            if (intendToRemoveParticipant.IsOwner)
                throw new NotAlloawedUserInRemoveFromChatException("Owner of chat can not be removed");

            if (!removerParticipant.IsOwner || !removerParticipant.IsAdmin)
                throw new NotAlloawedUserInRemoveFromChatException("Just admins can remove user");

            if (removerParticipant.IsAdmin && intendToRemoveParticipant.IsAdmin)
                throw new NotAlloawedUserInRemoveFromChatException("Admins can removed just by owner ");
            else
                return true;
        }

        private Guid GetCurrentUserId()
        {
            return Guid.Parse("1901b6b4-051f-4b0a-9606-f9cd11c3f0e9");
        }
    }
}
