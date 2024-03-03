using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Features.Sms.Contracts;
using Twitter.Clone.Notifier.Features.Sms.Settings;

namespace Twitter.Clone.Notifier.Features.Sms.Services
{
    public class SmsService : ISmsService
    {
        private readonly IOptions<FarapayamakSetting> _farapayamakOptions;
        public SmsService(IOptions<FarapayamakSetting> farapayamakOptions)
        {
            _farapayamakOptions = farapayamakOptions;
        }
        public async Task<bool> Send(string messageBody, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
