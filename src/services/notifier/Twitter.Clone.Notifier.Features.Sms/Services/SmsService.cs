using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Features.Sms.Contracts;
using Twitter.Clone.Notifier.Features.Sms.Models;
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
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://rest.payamak-panel.com/api/SmartSMS/Send");

            var content1 = new FarapayamakRequestModel
            {
                text = messageBody,
                password = _farapayamakOptions.Value.Password,
                to = phoneNumber,
                from = _farapayamakOptions.Value.SenderNumber,
                username = _farapayamakOptions.Value.UserName
            };
            var test1 = JsonConvert.SerializeObject(content1);
            var content = new StringContent(test1, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            throw new NotImplementedException();
        }
    }
}
