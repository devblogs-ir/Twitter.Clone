using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.ServiceManager;

namespace Twitter.Clone.Messenger.Features.GetUnreadMessage.Commands
{
    public class GetUnreadMessagesHandler : IRequestHandler<GetUnreadMessagesCommand, GetMessagesResponse>
    {
        private ILogger<GetUnreadMessagesHandler> _logger;
        private MessengerDbContext _context;

        public GetUnreadMessagesHandler(ILogger<GetUnreadMessagesHandler> logger, MessengerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public Task<GetMessagesResponse> Handle(GetUnreadMessagesCommand request, CancellationToken cancellationToken)
        {
            
            var messages = _context.PrivateMessages.Include(x => x.PrivateChat)
                .Where(x => (x.PrivateChat.TargetUserId == request.UserId &&
                             x.MessageStatus == Shared.Enums.MessageStatus.Sent));



            throw new NotImplementedException();



        }
    }
}
