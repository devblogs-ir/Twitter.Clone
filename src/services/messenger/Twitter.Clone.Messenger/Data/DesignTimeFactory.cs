using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Messanger.Data
{
    public class DesignTimeFactory : IDesignTimeDbContextFactory<MessengerDbContext>
    {
        public MessengerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
            string cs = "Data Source=.\\MSSQLSERVER2019;Initial Catalog=MessengerDB;Persist Security Info=True;User ID=sa;Password=!QAZ2wsx;TrustServerCertificate=True";
            
            optionsBuilder.UseSqlServer(cs);
            return new MessengerDbContext(optionsBuilder.Options);
        }
    }
}

