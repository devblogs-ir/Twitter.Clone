namespace Twitter.Clone.Settings.Entities;

public abstract class BlockedListSetting
{
    public int UserId { get; set; }
}

public class BlockedUser : BlockedListSetting
{
    public int BlockedUserId { get; set; }
}

public class BlockedPage : BlockedListSetting
{
    public int BlockedPageId { get; set; }
}