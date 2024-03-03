using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.UpdateMessageStatus
{
    public class UpdateMessageStatusHandler : IRequestHandler<UpdateMessageStatusCommand>
    {
        private readonly MessengerDbContext _context;
        private readonly ILogger<UpdateMessageStatusHandler> _logger;

        public UpdateMessageStatusHandler(MessengerDbContext context, ILogger<UpdateMessageStatusHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Handle(UpdateMessageStatusCommand request, CancellationToken cancellationToken)
        {
            var messages = _context.PrivateMessages.Where(x =>  request.MessageIds.Contains(x.PrivateMessageId));

            foreach (var item in messages)
            {
                item.MessageStatus =request.MessageStatus;
            }
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
