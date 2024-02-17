using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Service.Models;

namespace Twitter.Clone.Notifier.Service.Gateway
{
    public interface INotifierFacade
    {
        public Task<bool> SendAsync(NotificationRequest model, CancellationToken cancellationToken = default);
    }
}
