using System.ComponentModel.DataAnnotations;

namespace Twitter.Clone.Settings.Entities.Models;

public abstract class BlockedListSetting
{
    [Key]
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
}

public class BlockedUser : BlockedListSetting
{
    public int BlockedUserId { get; set; }
}

public class BlockedPage : BlockedListSetting
{
    public int BlockedPageId { get; set; }
}