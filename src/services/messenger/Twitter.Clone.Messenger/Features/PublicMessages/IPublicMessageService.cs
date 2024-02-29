using Twitter.Clone.Messenger.Models;

namespace Twitter.Clone.Messenger.Features.PublicMessages
{
    public interface IPublicMessageService
    {
        void AddUserToPublicMessage(Guid publicMessageId, Guid userId);

        bool IsUserInPublicMessage(Guid publicMessageId, Guid userId);

        Task<PublicMessage?> GetPublicMessageByIdAsync(Guid? publicMessageId);
    }
}
