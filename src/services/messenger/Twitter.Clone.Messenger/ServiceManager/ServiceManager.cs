using Messanger.Data;
using Twitter.Clone.Messenger.Features.DirectMessages.Services;
using Twitter.Clone.Messenger.Features.PublicMessages;
using Twitter.Clone.Messenger.Shared.SettingRequests;

namespace Twitter.Clone.Messenger.ServiceManager
{
    /// <summary>
    /// The ServiceManager class is responsible for managing and providing access to different services related to consoles and games. It implements
    /// the IServiceManager interface, which likely defines the contract for managing these services.
    /// In this specific implementation, the ServiceManager class has a constructor that takes a DataContext object as a parameter.This DataContext
    /// object is used to initialize the _context field.
    /// The ServiceManager class also has two properties: Console and Game.These properties are used to access instances of the IConsoleService and
    /// IGameService interfaces, respectively.The properties use lazy initialization, meaning that the services are only created when they are first
    /// accessed.If the services have not been created yet, the properties instantiate them using the DataContext object and return the instances.This
    /// ensures that the services are created only when needed and avoids unnecessary resource allocation.
    /// Additionally, the ServiceManager class has a SaveAsync method that saves changes made to the DataContext asynchronously.
    /// If we didn't have the ServiceManager class, the code implementation would need to handle the creation and management of the console and game
    /// services directly. This could result in duplicated code and decreased maintainability. The ServiceManager class provides a centralized and
    /// organized way to manage these services, making the code more modular and easier to maintain.
    /// </summary>
    public class ServiceManager : IServiceManager
    {
        private readonly MessengerDbContext _context;
        private IPublicMessageService? _publicMessageService;
        private ISettingService? _settingService;
        private IPrivateMessageService? _privateMessageService;

        public ServiceManager(MessengerDbContext context)
        {
            _context = context;
        }

        public IPublicMessageService PublicMessageService
        {
            get
            {
                if (_publicMessageService == null)
                    _publicMessageService = new PublicMessageService(_context);

                return _publicMessageService;
            }
        }

        public ISettingService SettingService
        {
            get
            {
                if (_settingService == null)
                    _settingService = new SettingService();

                return _settingService;
            }
        }

        public IPrivateMessageService privateMessageService
        {
            get
            {

            }
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
