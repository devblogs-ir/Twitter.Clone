using Twitter.Clone.Messenger.Features.PublicMessages;
using Twitter.Clone.Messenger.Shared.SettingRequests;

namespace Twitter.Clone.Messenger.ServiceManager
{
    public interface IServiceManager
    {
        IPublicMessageService PublicMessageService { get; }

        Task SaveAsync();

        ISettingService SettingService { get; }
    }
}
