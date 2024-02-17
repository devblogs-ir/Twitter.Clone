using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Service.PushService
{
    public interface IPushService 
    {
        public Task<bool> SendAsync(object model, CancellationToken cancellationToken = default);
    }
}
