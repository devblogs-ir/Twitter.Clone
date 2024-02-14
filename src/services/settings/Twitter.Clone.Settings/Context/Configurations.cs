using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Settings.Entities.Models;

namespace Twitter.Clone.Settings.Context;

public class Configurations
{
    public abstract class BaseEntityConfiguration<T> :
        IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserId).ValueGeneratedNever();
        }
    }

    public class BlockedUserConfiguration :
         BaseEntityConfiguration<BlockedUser>
    {
    }

    public class BlockedPageConfiguration :
        BaseEntityConfiguration<BlockedPage>
    {
    }

    public class SmsNotificationSettingConfiguration :
        BaseEntityConfiguration<SmsNotificationSetting>
    {
    }

    public class EmailNotificationSettingConfiguration :
        BaseEntityConfiguration<EmailNotificationSetting>
    {
    }
}
