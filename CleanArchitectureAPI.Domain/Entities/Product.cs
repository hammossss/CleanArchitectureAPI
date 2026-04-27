namespace CleanArchitectureAPI.Domain.Entities;

// Denna klass representerar en produkt i systemet.
// Den motsvarar en tabell i databasen.
public class Product
{
    // Primärnyckel (Primary Key)
    public int Id { get; set; }

    // Namnet på produkten
    public string Name { get; set; } = string.Empty;

    // Pris på produkten
    public decimal Price { get; set; }

    // Foreign Key – koppling till Category-tabellen
    public int CategoryId { get; set; }

    // Navigation property – gör att vi kan hämta kategori-information
    public Category? Category { get; set; }
}
