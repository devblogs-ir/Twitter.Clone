namespace Twitter.Clone.Settings.Entities.Models;

public abstract class BlockedListSetting : BaseEntity
{
}

public class BlockedUser : BlockedListSetting
{
    public int BlockedUserId { get; set; }
}

public class BlockedPage : BlockedListSetting
{
    public int BlockedPageId { get; set; }
}