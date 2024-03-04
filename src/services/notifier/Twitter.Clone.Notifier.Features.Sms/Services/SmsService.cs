using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Common.ApiCaller;
using Twitter.Clone.Notifier.Common.Enums;
using Twitter.Clone.Notifier.Features.Sms.Contracts;
using Twitter.Clone.Notifier.Features.Sms.Models;
using Twitter.Clone.Notifier.Features.Sms.Settings;

namespace Twitter.Clone.Notifier.Features.Sms.Services
{
    public class SmsService : ISmsService
    {
        private readonly IOptions<SmsProvidersSetting> _smsOptions;
        public SmsService(IOptions<SmsProvidersSetting> smsOptions)
        {
            _smsOptions = smsOptions;
        }
        public async Task<bool> Send(string messageBody, string phoneNumber)
        {
            var requestModel = new FarapayamakRequestModel();
            requestModel.text = messageBody;
            requestModel.to = phoneNumber;
            if (_smsOptions.Value.ActiveSmsProvider == nameof(SmsProviders.Farapayamak))
            {
                requestModel.password = _smsOptions.Value.FarapayamakSetting.Password;
                requestModel.username = _smsOptions.Value.FarapayamakSetting.UserName;
                requestModel.from = _smsOptions.Value.FarapayamakSetting.SenderNumber;
                var response = await ApiCaller.PostAsync(_smsOptions.Value.FarapayamakSetting.ApiUrl, requestModel);
                response.EnsureSuccessStatusCode();
                return true;
            }
            else if (_smsOptions.Value.ActiveSmsProvider == nameof(SmsProviders.SmsIr))
            {
                requestModel.password = _smsOptions.Value.SmsIrSetting.Password;
                requestModel.username = _smsOptions.Value.SmsIrSetting.UserName;
                requestModel.from = _smsOptions.Value.SmsIrSetting.SenderNumber;
                var response = await ApiCaller.PostAsync(_smsOptions.Value.SmsIrSetting.ApiUrl, requestModel);
                response.EnsureSuccessStatusCode();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
