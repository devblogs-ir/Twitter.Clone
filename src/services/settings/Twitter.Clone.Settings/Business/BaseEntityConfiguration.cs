using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Entities;

namespace Twitter.Clone.Settings.Business;

public abstract class BaseEntityConfiguration<T> :
    IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {

        builder.HasIndex(x => x.Id);
    }
}

