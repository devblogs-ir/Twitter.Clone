using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Twitter.Clone.Search.WebApi.Entities;

namespace Twitter.Clone.Search.WebApi.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
 


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

}
