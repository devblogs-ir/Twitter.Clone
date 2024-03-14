using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Features.Sms.Settings
{
    public class SmsProvidersSetting
    {
        public const string SectionName = "SmsProvidersSetting";
        public string ActiveSmsProvider { get;}
        public FarapayamakSetting FarapayamakSetting { get; set; }
        public SmsIrSetting SmsIrSetting { get; set; }
    }
}
