namespace Twitter.Clone.Tweet.Infrastructure.Persistence.DbContext;

using Microsoft.EntityFrameworkCore; 
using Twitter.Clone.Tweet.Domain.Entities;
using Twitter.Clone.Tweet.Infrastructure.Persistence.Configuration;

public class TweetDbContext(DbContextOptions<TweetDbContext> options): DbContext(options)
{  
    public DbSet<TweetEntity> Tweets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TweetEntityConfig());
        base.OnModelCreating(modelBuilder);
    }
}