
using asp_mvc_test.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_mvc_test.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}
