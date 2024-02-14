

namespace Twitter.Clone.Settings.Infrastructure.Configuration;

public class BlockedPageConfiguration : IEntityTypeConfiguration<BlockedPage>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<BlockedPage> builder)
    {
        builder.HasIndex(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();
    }
}

