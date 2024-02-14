using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Shared.Common.Models;

namespace Twitter.Clone.Notifier.Shared.Domain
{
    public class Notification : Entity
    {
        public string MessageBody { get; set; }
    }
}
