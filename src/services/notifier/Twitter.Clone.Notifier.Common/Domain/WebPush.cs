using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Shared.Domain
{
    public class WebPush : Notification
    {
        public string ClientId { get; set; }
    }
}
