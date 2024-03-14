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

        modelBuilder.Entity<HashTag>(tagBuilder =>
        {
            tagBuilder.ToTable(name: HashTag.TableName, schema: DefaultSchema);

            tagBuilder.HasKey(x => x.Id);

            tagBuilder.Property(x => x.Name)
                      .HasMaxLength(40)
                      .IsUnicode(true)
                      .IsRequired();

            tagBuilder.HasIndex(x => x.Name)
                      .IsUnique()
                      .IsClustered(false);

            tagBuilder.OwnsMany(x => x.Entries, 
                entry => 
                {
                    entry.ToTable(name: HashTagEntry.TableName, schema: DefaultSchema);
                    entry.WithOwner().HasForeignKey(tag => tag.HashTagId);

                    entry.Property(e => e.Processed).IsRequired();

                    entry.Property(e => e.IPAddress)
                         .IsRequired()
                         .HasMaxLength(45)
                         .IsUnicode(true);

                    entry.Property(e => e.CreatedOn)
                         .HasDefaultValueSql("GETDATE()")
                         .IsRequired();
                });
        });
    }
}
