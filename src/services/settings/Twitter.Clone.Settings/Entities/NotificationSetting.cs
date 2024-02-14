namespace Twitter.Clone.Settings.Entities;

public abstract class NotificationSetting
{
    public int UserId { get; set; }
    public bool IsActive { get; set; }
}

public class EmailNotificationSetting : NotificationSetting
{
    public bool IsMentionActive { get; set; }
    public bool IsDirectMessageActive { get; set; }
    public bool IsFollowActive { get; set; }
}

public class SmsNotificationSetting : NotificationSetting
{
    public bool IsPasswordChangeActive { get; set; }
}