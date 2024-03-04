﻿    using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.Models;

namespace Twitter.Clone.Messenger.Features.PublicMessages
{
    public class PublicMessageService : IPublicMessageService
    {
        private readonly MessengerDbContext _context;

        public PublicMessageService(MessengerDbContext context)
        {
            _context = context;
        }

        public void AddUserToPublicMessage(Guid publicMessageId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<PublicMessage?> GetPublicMessageByIdAsync(Guid? publicMessageId)
        {
            return await _context.PublicMessages
                .Include(pm => pm.Participants)
                .FirstOrDefaultAsync(pm => pm.Id == publicMessageId);
        }

        public bool IsUserInPublicMessage(Guid publicMessageId, Guid userId)
        {
            return _context.Participants
                .Any(par => par.PublicMessageId == publicMessageId && par.UserId == userId);
        }
    }
}
