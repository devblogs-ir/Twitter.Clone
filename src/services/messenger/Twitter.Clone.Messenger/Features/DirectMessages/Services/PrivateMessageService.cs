using Azure.Core;
using MediatR;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Twitter.Clone.Messenger.Features.DirectMessages.Commands;
using Twitter.Clone.Messenger.Models;

namespace Twitter.Clone.Messenger.Features.DirectMessages.Services
{
    public class PrivateMessageService(MessengerDbContext dbContext) : IPrivateMessageService
    {
        private readonly MessengerDbContext _dbContext = dbContext;

        public Task<PrivateChat> AddPrivateChat(Guid StarterUser, Guid TargetUSer)
        {
            var privateChat = new PrivateChat
            {
                ChatName = "",
                LastMessageBrief = string.Empty,
                IsDeletedForStarter = false,
                IsDeletedForTarget = false,
                LastMessageDateTime = DateTime.MinValue,
                StarterUserId = StarterUser,
                TargetUserId = TargetUSer,
                UnseenNumbers = new byte { }
            };
            _dbContext.PrivateChats.Add(privateChat);
            return privateChat;
        }

        public long AddPrivateMessage(CreatePrivateMessage createPrivateMessage, PrivateChat privateChat)
        {
            var privateMessage = new PrivateMessage
            {
                DeliverDateTime = DateTime.UtcNow,
                IsEdited = false,
                IsDeletedForStarter = false,
                IsDeletedForTarget = false,
                IsForStarter = createPrivateMessage.StarterUserId == createPrivateMessage.StarterUserId,
                MessageBody = createPrivateMessage.MessageBody,
                MessageStatus = Shared.Enums.MessageStatus.Draft,
                PrivateChatId = privateChat.ChatId,
                PrivateChat = privateChat //چرا باید حتما اینو مقداردهی کنیم؟
            };
            _dbContext.PrivateMessages.Add(privateMessage);
            return privateMessage.PrivateMessageId;
        }

        public PrivateChat? GetPrivateChat(Guid StarterUser, Guid TargetUSer)
        {
            var privateChat = _dbContext.PrivateChats
            .SingleOrDefault(x => ((x.StarterUserId == StarterUser && x.TargetUserId == TargetUSer) ||
            (x.StarterUserId == TargetUSer && x.TargetUserId == StarterUser)) &&
            (!x.IsDeletedForStarter || !x.IsDeletedForTarget));
            return privateChat;
        }

        public bool IsExistPrivateChat(Guid StarterUser, Guid TargetUSer)
        {
            throw new NotImplementedException();
        }
    }
}