namespace Twitter.Clone.Trends.Persistence;

public sealed class TrendDbContext : DbContext
{
    public TrendDbContext(DbContextOptions<TrendDbContext> dbContextOptions) : base(dbContextOptions)
    {
            
    }
}
