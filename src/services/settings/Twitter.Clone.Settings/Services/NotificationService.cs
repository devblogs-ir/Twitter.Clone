using Grpc.Core;
using Twitter.Clone.Settings.Business;
using Twitter.Clone.Settings.Context;

namespace Twitter.Clone.Settings.Services;

public class NotificationService : Notification.NotificationBase
{
    private readonly SettingsDbContext _dbContext;

    public NotificationService(SettingsDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public override Task<GetUserNotificationSettingsReply> GetUserNotificationSettings(
        GetUserNotificationSettingsRequest request,
        ServerCallContext context)
    {
        UserNotificationResponse response = new()
        {
            EmailNotificationSetting = _dbContext.EmailNotificationSettings.
            SingleOrDefault(p => p.UserId.ToString() == request.UserId)!,
            SmsNotificationSetting = _dbContext.SmsNotificationSettings
            .SingleOrDefault(p => p.UserId.ToString() == request.UserId)!,
        };

        return Task.FromResult(new GetUserNotificationSettingsReply
        {
            IsEmailActive = response.EmailNotificationSetting.IsActive,
            IsMentionActive = response.EmailNotificationSetting.IsMentionActive,
            IsDirectMessageActive = response.EmailNotificationSetting.IsDirectMessageActive,
            IsFollowActive = response.EmailNotificationSetting.IsFollowActive,
            IsSmsActive = response.SmsNotificationSetting.IsActive,
            IsPasswordChangeActive = response.SmsNotificationSetting.IsPasswordChangeActive
        });
    }
}
