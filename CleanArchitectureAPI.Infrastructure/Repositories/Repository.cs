using Microsoft.EntityFrameworkCore;
using CleanArchitectureAPI.Domain.Interfaces;
using CleanArchitectureAPI.Infrastructure.Data;

namespace CleanArchitectureAPI.Infrastructure.Repositories;

// Detta är implementationen av IRepository.
// Den använder Entity Framework Core för att prata med databasen.
public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;

    // Konstruktor – Dependency Injection används för att få DbContext
    public Repository(AppDbContext context)
    {
        _context = context;
    }

    // Hämtar alla objekt från databasen
    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    // Hämtar ett objekt baserat på ID
    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    // Lägger till nytt objekt
    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync(); // Sparar ändringar i databasen
    }

    // Uppdaterar objekt
    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    // Tar bort objekt
    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}
