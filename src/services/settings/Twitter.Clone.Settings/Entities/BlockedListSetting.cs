using System.ComponentModel.DataAnnotations;

namespace Twitter.Clone.Settings.Entities;

public abstract class BlockedListSetting : BaseEntity
{
}

public class BlockedUser : BlockedListSetting
{
    public Guid BlockedUserId { get; set; }
}

public class BlockedPage : BlockedListSetting
{
    public Guid BlockedPageId { get; set; }
}