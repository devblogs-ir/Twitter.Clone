using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Messanger.Data
{
    public class DesignTimeFactory : IDesignTimeDbContextFactory<MessengerDbContext>
    {
        public MessengerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
            string cs = $"Data Source={Environment.MachineName};Initial Catalog=MessengerDB;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(cs);
            return new MessengerDbContext(optionsBuilder.Options);
        }
    }
}

