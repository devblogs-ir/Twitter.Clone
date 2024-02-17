using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Twitter.Clone.Settings.Business;

public class SmsNotificationConfiguration : BaseEntityConfiguration<SmsNotificationSetting>
{
    public override void Configure(EntityTypeBuilder<SmsNotificationSetting> builder)
    {
        base.Configure(builder);
        builder.HasIndex(p => p.UserId).IsUnique();
    }
}
