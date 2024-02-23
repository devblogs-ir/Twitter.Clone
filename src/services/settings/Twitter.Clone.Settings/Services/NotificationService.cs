using Grpc.Core;
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
        var emailSettings = _dbContext.EmailNotificationSettings.
            FirstOrDefault(p => p.UserId.ToString() == request.UserId)!;
        var smsSettings = _dbContext.SmsNotificationSettings.
            FirstOrDefault(p => p.UserId.ToString() == request.UserId)!;

        return Task.FromResult(new GetUserNotificationSettingsReply
        {
            Email = new EmailNotificationSettingsReply
            {
                IsActive = emailSettings.IsActive,
                IsDirectMessageActive = emailSettings.IsDirectMessageActive,
                IsFollowActive = emailSettings.IsFollowActive,
                IsMentionActive = emailSettings.IsMentionActive
            },
            Sms = new SmsNotificationSettingsReply
            {
                IsActive = smsSettings.IsActive,
                IsPasswordChangeActive = smsSettings.IsPasswordChangeActive,
            }
        });
    }
}
