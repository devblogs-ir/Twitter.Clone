using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Domain.Entities;

namespace Twitter.Clone.Settings.Infrastructure.Persistence.Context;

public class NotificationSettingsDbContext : DbContext
{
    public DbSet<NotificationSetting> NotificationSetting { get; set; }
    public DbSet<EmailNotificationSetting> EmailNotificationSetting { get; set; }
    public DbSet<SmsNotificationSetting> SmsNotificationSetting { get; set;}

    public NotificationSettingsDbContext(DbContextOptions<NotificationSettingsDbContext> options) : base(options) 
    { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
    }
}
