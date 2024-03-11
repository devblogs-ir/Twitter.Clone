using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Features.Sms.Models
{
    public class FarapayamakRequestModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string to { get; set; }
        public string text { get; set; }
        public string from { get; set; }
    }
}
