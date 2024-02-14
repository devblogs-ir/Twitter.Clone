using Azure;
using Twitter.Clone.Settings.Entities.Dtos;
using Twitter.Clone.Settings.Entities.Models;

namespace Twitter.Clone.Settings.Entities.Builders
{
    public class NotificationSettingsBuilder
    {
        private NotificationSettingsDto _response;
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

        public NotificationSettingsDto Build() => _response;
    }
}
