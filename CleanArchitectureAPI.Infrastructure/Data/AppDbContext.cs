using Microsoft.EntityFrameworkCore;
using CleanArchitectureAPI.Domain.Entities;

namespace CleanArchitectureAPI.Infrastructure.Data;

// DbContext är kopplingen mellan applikationen och SQL-databasen.
// Här definierar vi vilka tabeller som ska finnas.
public class AppDbContext : DbContext
{
    // Konstruktor som tar emot inställningar för databasen
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Products-tabellen i databasen
    public DbSet<Product> Products => Set<Product>();

    // Categories-tabellen i databasen
    public DbSet<Category> Categories => Set<Category>();
}
