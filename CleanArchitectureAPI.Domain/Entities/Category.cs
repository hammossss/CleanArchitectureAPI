namespace CleanArchitectureAPI.Domain.Entities;

// Denna klass representerar en kategori.
// En kategori kan ha flera produkter (1-till-många-relation).
public class Category
{
    // Primärnyckel
    public int Id { get; set; }

    // Namn på kategorin
    public string Name { get; set; } = string.Empty;

    // Navigation property
    // En kategori kan innehålla flera produkter
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
