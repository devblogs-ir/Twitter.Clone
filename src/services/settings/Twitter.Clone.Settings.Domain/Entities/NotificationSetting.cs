namespace Twitter.Clone.Settings.Domain.Entities;

public abstract class NotificationSetting
{
    public int UserId { get; set; }
    public bool IsNotificationActive { get; set; }

    //public bool IsEmailNotificationActive { get; set; }
    //public bool IsSmsNotificationActive { get; set; }
}

public class EmailNotificationSetting : NotificationSetting
{
    public bool IsMentionNotifActive { get; set; }
    public bool IsDirectMessageNotifActive { get; set; }
    public bool IsFollowNotifActive { get; set; }
}

public class SmsNotificationSetting : NotificationSetting
{
    public bool IsPasswordChangeNotifActive { get; set; }
}