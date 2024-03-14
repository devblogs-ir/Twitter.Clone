using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Features.Sms.Settings
{

    public class FarapayamakSetting
    {
        public const string SectionName = "FarapayamakSetting";
        public string ProviderName { get; set; }
        public string ApiUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SenderNumber { get; set; }
    }
}
