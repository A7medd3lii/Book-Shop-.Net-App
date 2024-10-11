namespace BookShop.Data;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
    }

    public DbSet<BookEntity> Books { get; set; }
}
