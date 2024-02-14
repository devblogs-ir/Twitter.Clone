using Twitter.Clone.Settings.Entities.Models;

namespace Twitter.Clone.Settings.Entities.Dtos
{
    public class NotificationSettingsDto
    {
        public SmsNotificationSetting? SmsNotificationSetting { get; set; }
        public EmailNotificationSetting? EmailNotificationSetting { get; set; }
    }
}
