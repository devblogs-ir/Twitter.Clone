using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Entities;

namespace Twitter.Clone.Settings.Business;

public abstract class BaseEntityConfiguration<T> :
    IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasIndex(p => p.UserId).IsUnique();
    }
}

