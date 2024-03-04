using Twitter.Clone.Messenger.Features.DirectMessages.Services;
using Twitter.Clone.Messenger.Features.PublicMessages;
using Twitter.Clone.Messenger.Shared.SettingRequests;

namespace Twitter.Clone.Messenger.ServiceManager
{
    public interface IServiceManager
    {
        IPublicMessageService PublicMessageService { get; }

        IPrivateMessageService privateMessageService { get; }

        Task SaveAsync();

        ISettingService SettingService { get; }
    }
}
