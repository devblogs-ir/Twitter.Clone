using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Settings.Domain.Entities;
using Twitter.Clone.Settings.Infrastructure.Persistence.Context;

namespace Twitter.Clone.Settings.Infrastructure.Configuration;

public class SmsNotificationConfiguration : IEntityTypeConfiguration<SmsNotificationSetting>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<SmsNotificationSetting> builder)
    {
        builder.HasKey(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();

    }
}
