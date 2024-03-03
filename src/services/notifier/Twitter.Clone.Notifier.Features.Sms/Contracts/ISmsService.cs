using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Features.Sms.Contracts
{
    public interface ISmsService
    {
        Task<bool> Send(string messageBody, string phoneNumber);
    }
}
