using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Service.Models
{
    public enum DeliveryChannel : byte
    {
        ShortMessage = 1,
        Email = 2,
        WebPush = 3
    }
}
