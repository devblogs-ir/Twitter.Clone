namespace Twitter.Clone.Locator.Persistence;

public class LocatorDbContext : DbContext
{
    public const string DefaultSchema = "locator";

    public DbSet<Location> Locations => Set<Location>();

    public LocatorDbContext(DbContextOptions<LocatorDbContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Location>(builder =>
        {
            builder.ToTable(name: Location.TableName, schema: DefaultSchema);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            
            builder.Property(x => x.ContinentName)
                   .HasMaxLength(15)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(x => x.CountryName)
                   .HasMaxLength(35)
                   .IsUnicode(false)
                   .IsRequired();

            builder.Property(x => x.CountryCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsRequired();

            builder.Property(x => x.State)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsRequired();

            builder.Property(x => x.City)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .IsRequired();

            builder.Property(x => x.CallingCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsRequired();
        });
    }
}
