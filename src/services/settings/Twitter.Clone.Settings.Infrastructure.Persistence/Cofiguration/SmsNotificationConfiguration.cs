global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Twitter.Clone.Settings.Infrastructure.Persistence.Context;

namespace Twitter.Clone.Settings.Infrastructure.Configuration;

public class SmsNotificationConfiguration : IEntityTypeConfiguration<SmsNotificationSetting>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<SmsNotificationSetting> builder)
    {
        builder.HasKey(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();

    }
} 

