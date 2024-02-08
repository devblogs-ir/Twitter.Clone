using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Twitter.Clone.IdentityPrvider.Infrastructure;

public class IdentityContext(DbContextOptions<IdentityContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
