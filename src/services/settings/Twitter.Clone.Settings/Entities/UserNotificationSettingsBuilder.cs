using Azure;

namespace Twitter.Clone.Settings.Entities
{
    public class UserNotificationSettingsBuilder
    {
        private UserNotificationSettingsResponse _response;
        public UserNotificationSettingsBuilder WithEmailSettings(EmailNotificationSetting settings)
        {
            _response.EmailNotificationSetting = settings;
            return this;
        }

        public UserNotificationSettingsBuilder WithSmsSettings(SmsNotificationSetting settings)
        {
            _response.SmsNotificationSetting = settings;
            return this;
        }

        public UserNotificationSettingsResponse Build() => _response;
    }
}
