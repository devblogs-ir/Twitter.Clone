using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Twitter.Clone.Search.WebApi.Entities;

namespace Twitter.Clone.Search.WebApi.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Tweet> Tweets { get; set; }
    public DbSet<TweetHashtag> TweetHashtags { get; set; }
    public DbSet<Hashtag> Hashtags { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

}
