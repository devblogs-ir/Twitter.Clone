using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Domain.Entities;
using Twitter.Clone.Settings.Infrastructure.Persistence.Context;

namespace Twitter.Clone.Settings.Infrastructure.Configuration;

public class BlockedPageConfiguration : IEntityTypeConfiguration<BlockedPage>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<BlockedPage> builder)
    {
        builder.HasIndex(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();
    }
}

