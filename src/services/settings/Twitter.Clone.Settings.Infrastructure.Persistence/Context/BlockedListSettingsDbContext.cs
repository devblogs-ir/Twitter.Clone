using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Domain.Entities;

namespace Twitter.Clone.Settings.Infrastructure.Persistence.Context;

public class BlockedListSettingsDbContext : DbContext
{
    public DbSet<BlockedUser> NotificationSetting { get; set; }
    public DbSet<BlockedPage> EmailNotificationSetting { get; set; }

    public BlockedListSettingsDbContext(DbContextOptions<BlockedListSettingsDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
    }
}
