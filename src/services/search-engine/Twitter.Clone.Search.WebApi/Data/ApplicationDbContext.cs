using Microsoft.EntityFrameworkCore;

namespace Twitter.Clone.Search.WebApi.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    
}
