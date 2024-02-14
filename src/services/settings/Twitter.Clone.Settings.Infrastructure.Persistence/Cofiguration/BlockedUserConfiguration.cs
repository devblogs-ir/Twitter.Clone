using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Settings.Infrastructure.Persistence.Context;

namespace Twitter.Clone.Settings.Infrastructure.Configuration;

public class BlockedUserConfiguration : IEntityTypeConfiguration<BlockedUser>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<BlockedUser> builder)
    {
        builder.HasIndex(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();
    }
}

