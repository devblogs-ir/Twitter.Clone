namespace Twitter.Clone.Settings.Entities
{
    public class UserNotificationSettingsResponse
    {
        public SmsNotificationSetting? SmsNotificationSetting { get; set; }
        public EmailNotificationSetting? EmailNotificationSetting { get; set; }
    }
}
