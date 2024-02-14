using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Entities;

namespace Twitter.Clone.Settings.Context;

public class SettingsDbContext : DbContext
{
    public SettingsDbContext(DbContextOptions<SettingsDbContext> options)
        : base(options)
    {

    }

    #region BlockedList
    public DbSet<BlockedListSetting> BlockedListSettings { get; set; }
    public DbSet<BlockedUser> BlockedUsers { get; set; }
    public DbSet<BlockedPage> BlockedPages { get; set; }
    #endregion

    #region Notification
    public DbSet<NotificationSetting> NotificationSettings { get; set; }
    public DbSet<EmailNotificationSetting> EmailNotificationSettings { get; set; }
    public DbSet<SmsNotificationSetting> SmsNotificationSettings { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlockedListSetting>().UseTpcMappingStrategy();
        modelBuilder.Entity<NotificationSetting>().UseTpcMappingStrategy();
    }
}
