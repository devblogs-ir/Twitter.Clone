using Azure;

namespace Twitter.Clone.Settings.Entities
{
    public class NotificationSettingsBuilder
    {
        private NotificationSettingsResponse _response;
        public NotificationSettingsBuilder WithEmailSettings(EmailNotificationSetting settings)
        {
            _response.EmailNotificationSetting = settings;
            return this;
        }

        public NotificationSettingsBuilder WithSmsSettings(SmsNotificationSetting settings)
        {
            _response.SmsNotificationSetting = settings;
            return this;
        }

        public NotificationSettingsResponse Build() => _response;
    }
}
