using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Search.WebApi.Entities;

namespace Twitter.Clone.Search.WebApi.Context.Configurations;

public class TweetConfigurations : IEntityTypeConfiguration<Tweet>
{
    public void Configure(EntityTypeBuilder<Tweet> builder)
    {
        builder.HasMany(e => e.Hashtags)
                .WithMany(e => e.Tweets)
                .UsingEntity<TweetHashtag>();
    }
}
