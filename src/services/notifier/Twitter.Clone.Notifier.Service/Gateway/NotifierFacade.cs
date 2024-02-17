using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Features.ShortMessage.Services;
using Twitter.Clone.Notifier.Service.Models;

namespace Twitter.Clone.Notifier.Service.Gateway
{
    public class NotifierFacade : INotifierFacade
    {
        private readonly IShortMessageProvider _shortMessageProvider;

        public NotifierFacade(IShortMessageProvider shortMessageProvider)
        {
            _shortMessageProvider = shortMessageProvider;
        }
        public async Task<bool> SendAsync(NotificationRequest model, CancellationToken cancellationToken = default)
        {
            var userPhoneNumber = GetUserPhoneNumber();
            if(model.DeliveryChannels.Contains(DeliveryChannel.ShortMessage))
            {
                await _shortMessageProvider.SendAsync(new Features.ShortMessage.Models.ShortMessageModel
                {
                    MessageBody= model.MessageBody,
                    PhoneNumber= userPhoneNumber

                }, cancellationToken: cancellationToken);
            }

            // 1-Query the settings service and check permissions
            // 2- Send notifications to channels
            throw new NotImplementedException();
        }

        private string GetUserPhoneNumber()
        {
            // get user phone number throw setting service
            throw new NotImplementedException();
        }
    }
}
