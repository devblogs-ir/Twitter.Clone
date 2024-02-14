using Grpc.Core;
using Twitter.Clone.Settings.Context;
using Twitter.Clone.Settings.Entities.Builders;

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
        var response = new NotificationSettingsBuilder().
            WithEmailSettings(_dbContext.EmailNotificationSettings.
            Find(request.UserId)!).
            WithSmsSettings(_dbContext.SmsNotificationSettings
            .Find(request.UserId)!)
            .Build();


        return Task.FromResult(new GetUserNotificationSettingsReply
        {
            IsEmailActive = response.EmailNotificationSetting!.IsActive!,
            IsMentionActive = response.EmailNotificationSetting.IsMentionActive,
            IsDirectMessageActive = response.EmailNotificationSetting.IsDirectMessageActive,
            IsFollowActive = response.EmailNotificationSetting.IsFollowActive,
            IsSmsActive = response.SmsNotificationSetting!.IsActive,
            IsPasswordChangeActive = response.SmsNotificationSetting.IsPasswordChangeActive
        });
    }
}
