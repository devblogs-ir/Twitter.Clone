using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Context;
using Twitter.Clone.Settings.Entities;

namespace Twitter.Clone.Settings.Business;

public class UserNotificationResponse
{
    public SmsNotificationSetting? SmsNotificationSetting { get; set; }
    public EmailNotificationSetting? EmailNotificationSetting { get; set; }
}
