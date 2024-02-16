using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Search.WebApi.Entities;

namespace Twitter.Clone.Search.WebApi.Context.Configurations;

public class HashtagConfigurations : IEntityTypeConfiguration<Hashtag>
{
    public void Configure(EntityTypeBuilder<Hashtag> builder)
    {
        throw new NotImplementedException();
    }
}
