using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Core.Autofac;
using Twitter.Clone.Notifier.Features.ShortMessage.Models;

namespace Twitter.Clone.Notifier.Features.ShortMessage.Services
{
    public interface IShortMessageProvider : ISingletonDependency
    {
        public Task<bool> SendAsync(ShortMessageModel model, CancellationToken cancellationToken = default);
    }

    public class ShortMessageService : IShortMessageProvider
    {
        public Task<bool> SendAsync(ShortMessageModel model, CancellationToken cancellationToken = default)
        {
            // send Short message throw infrastructure
            throw new NotImplementedException();
        }
    }
}
