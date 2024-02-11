namespace Twitter.Clone.Tweet.Infrastructure.Persistence.Configuration;
 
using Twitter.Clone.Tweet.Domain.Entities;
using MongoDB.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TweetEntityConfig : IEntityTypeConfiguration<TweetEntity>
{
    public void Configure(EntityTypeBuilder<TweetEntity> builder)
    {
        builder.ToCollection("Tweets");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Text).IsRequired();
    }
}
