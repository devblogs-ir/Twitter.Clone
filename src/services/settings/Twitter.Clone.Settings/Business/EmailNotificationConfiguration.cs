using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Twitter.Clone.Settings.Business;

public class EmailNotificationConfiguration : BaseEntityConfiguration<EmailNotificationSetting>
{
    public override void Configure(EntityTypeBuilder<EmailNotificationSetting> builder)
    {
        base.Configure(builder);
        builder.HasIndex(p => p.UserId).IsUnique();
    }
}
