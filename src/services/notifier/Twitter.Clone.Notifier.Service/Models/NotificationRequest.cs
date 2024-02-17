using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Service.Models
{
    public class NotificationRequest
    {
        public string UserId { get; set; } = string.Empty;
        public string MessageBody { get; set; }= string.Empty;
        public List<DeliveryChannel> DeliveryChannels { get; set; } = new List<DeliveryChannel>();
    }
}
