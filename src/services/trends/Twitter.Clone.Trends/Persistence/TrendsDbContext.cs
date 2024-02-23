using Twitter.Clone.Trends.Models.Entities;

namespace Twitter.Clone.Trends.Persistence;

public sealed class TrendsDbContext : DbContext
{
    public const string DefaultSchema = "trends";
    public const string ConnectionStringSectionName = "TrendsDb";

    public TrendsDbContext(DbContextOptions<TrendsDbContext> dbContextOptions) : base(dbContextOptions)
    {
            
    }

    public DbSet<HashTag> HashTags => Set<HashTag>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<HashTag>(builder =>
        {
            builder.ToTable(name: HashTag.TableName, schema: DefaultSchema);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Processed).IsRequired();

            builder.Property(x => x.Name)
                   .HasMaxLength(40)
                   .IsUnicode(true)
                   .IsRequired();

            builder.Property(x => x.CreatedOn)
                    .HasDefaultValueSql("GETDATE()")
                    .IsRequired();
        });
    }
}
