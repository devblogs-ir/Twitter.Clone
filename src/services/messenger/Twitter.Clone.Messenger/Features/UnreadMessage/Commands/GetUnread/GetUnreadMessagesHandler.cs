using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.ServiceManager;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.GetUnread
{
    public class GetUnreadMessagesHandler : IRequestHandler<GetUnreadMessagesCommand, IEnumerable<GetUnreadMessagesResponse>>
    {
        private ILogger<GetUnreadMessagesHandler> _logger;
        private MessengerDbContext _context;

        public GetUnreadMessagesHandler(ILogger<GetUnreadMessagesHandler> logger, MessengerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IEnumerable<GetUnreadMessagesResponse>> Handle(GetUnreadMessagesCommand request, CancellationToken cancellationToken)
        {
            var messages = await _context.PrivateMessages
                .Include(x => x.PrivateChat)
                .Where(x => x.PrivateChat.TargetUserId.ToString() == request.UserId &&
                             x.MessageStatus == Shared.Enums.MessageStatus.Delivered)
                .AsNoTracking()
                .Select(x => new GetUnreadMessagesResponse() { MessageBody = x.MessageBody, PrivateMessageId = x.PrivateMessageId })
                .ToListAsync();

            //update message status to seen
            //var messagesList = dbMessages.AsEnumerable();
            //foreach (var message in messagesList)
            //{
            //    message.MessageStatus = Shared.Enums.MessageStatus.Seen;
            //}
            //await _context.SaveChangesAsync();

            return messages;
        }
    }
}
