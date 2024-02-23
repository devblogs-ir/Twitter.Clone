using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Entities;

namespace Twitter.Clone.Settings.Context;

public class SettingsDbContext(DbContextOptions<SettingsDbContext> options) : DbContext(options)
{
    #region BlockedList
    public DbSet<BlockedUser> BlockedUsers { get; set; }
    public DbSet<BlockedPage> BlockedPages { get; set; }
    #endregion

    #region Notification
    public DbSet<EmailNotificationSetting> EmailNotificationSettings { get; set; }
    public DbSet<SmsNotificationSetting> SmsNotificationSettings { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SettingsDbContext).Assembly);
    }
}
