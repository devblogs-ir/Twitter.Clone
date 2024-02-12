using Microsoft.EntityFrameworkCore;

namespace Twitter.Clone.Search.Infrastracture;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}
