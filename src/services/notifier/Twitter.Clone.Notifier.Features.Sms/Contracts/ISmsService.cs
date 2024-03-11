using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Common.Autofac;

namespace Twitter.Clone.Notifier.Features.Sms.Contracts
{
    public interface ISmsService : ISingletonDependency
    {
        Task<bool> Send(string messageBody, string phoneNumber);
    }
}
