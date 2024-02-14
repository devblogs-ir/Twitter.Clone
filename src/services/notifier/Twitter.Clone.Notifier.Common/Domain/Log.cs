using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Clone.Notifier.Shared.Common.Models;

namespace Twitter.Clone.Notifier.Shared.Domain
{
    public class Log: Entity
    {
        public string ClientIp { get; internal set; }
        public string EndPointUrl { get; internal set; }
        public Exception Exception { get; internal set; }
    }
}
