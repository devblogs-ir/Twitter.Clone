using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Shared.Common.Models;

namespace Twitter.Clone.Notifier.Shared.Domain
{
    public class ShorteMessage : Notification, IDeliverable
    {
        public string PhoneNumber { get; set; }
        public bool Deliverd { get ; set ; }
    }
}
