using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Messenger.Models;

namespace Twitter.Clone.Messenger.Features.DirectMessages.Commands
{
    public class CreatePrivateChatHandler(MessengerDbContext dbContext) : 
        IRequestHandler<CreatePrivateChat, long>
    {
        private  MessengerDbContext _dbContext { get; } = dbContext;

        public async Task<long> Handle(CreatePrivateChat request, CancellationToken cancellationToken)
        {
            //var ExistChat = _dbContext.PrivateChats.Any(x => ((x.StarterUserId == request.StarterUserId && x.TargetUserId == request.TargetUserId) ||
            //(x.StarterUserId == request.TargetUserId && x.TargetUserId == request.StarterUserId)) && (!x.IsDeletedForStarter || !x.IsDeletedForTarget));
            //var p = new PrivateChat();
            //does it possible to use single method?
            var privateChat = _dbContext.PrivateChats
                .SingleOrDefault(x => ((x.StarterUserId == request.StarterUserId && x.TargetUserId == request.TargetUserId) ||
                            (x.StarterUserId == request.TargetUserId && x.TargetUserId == request.StarterUserId)) && 
                            (!x.IsDeletedForStarter || !x.IsDeletedForTarget));
            if (privateChat is null)
            {
                privateChat = new PrivateChat
                {
                    ChatName = "",
                    LastMessageBrief = string.Empty,
                    IsDeletedForStarter = false,
                    IsDeletedForTarget = false,
                    LastMessageDateTime = DateTime.MinValue,
                    StarterUserId = request.StarterUserId,
                    TargetUserId = request.TargetUserId,
                    UnseenNumbers = new byte { } 
                };
                _dbContext.PrivateChats.Add(privateChat);
                await _dbContext.SaveChangesAsync(cancellationToken);
            }

            var privateMessage = new PrivateMessage
            {
                DeliverDateTime = DateTime.UtcNow,
                IsEdited = false,
                IsDeletedForStarter = false,
                IsDeletedForTarget = false,
                IsForStarter = request.StarterUserId == privateChat.StarterUserId,
                MessageBody = request.MessageBody,
                MessageStatus = Enums.MessageStatus.Draft,
                PrivateChatId = privateChat.ChatId,
                PrivateChat = privateChat //چرا باید حتما اینو مقداردهی کنیم؟
            };
            _dbContext.PrivateMessages.Add(privateMessage);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return privateMessage.PrivateMessageId;
        }
    }
}
