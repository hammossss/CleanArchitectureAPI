namespace CleanArchitectureAPI.Domain.Interfaces;

// Detta är ett generiskt repository-interface.
// Det fungerar som ett kontrakt för databasanrop.
// Infrastructure-lagret kommer implementera detta.
public interface IRepository<T> where T : class
{
    // Hämtar alla objekt från databasen
    Task<List<T>> GetAllAsync();

    // Hämtar ett objekt baserat på ID
    Task<T?> GetByIdAsync(int id);

    // Lägger till ett nytt objekt i databasen
    Task AddAsync(T entity);

    // Uppdaterar ett befintligt objekt
    Task UpdateAsync(T entity);

    // Tar bort ett objekt
    Task DeleteAsync(T entity);
}
