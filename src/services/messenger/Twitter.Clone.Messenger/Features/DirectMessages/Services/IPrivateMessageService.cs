using Twitter.Clone.Messenger.Features.DirectMessages.Commands;
using Twitter.Clone.Messenger.Models;

namespace Twitter.Clone.Messenger.Features.DirectMessages.Services
{
    public interface IPrivateMessageService
    {
        bool IsExistPrivateChat(Guid StarterUser, Guid TargetUSer);
        PrivateChat? GetPrivateChat(Guid StarterUser, Guid TargetUSer);
        Task<PrivateChat> AddPrivateChat(Guid StarterUser, Guid TargetUSer);

        long AddPrivateMessage(CreatePrivateMessage createPrivateMessage, PrivateChat privateChat);//cupling?
    }
}