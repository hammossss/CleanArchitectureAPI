using MediatR;
using CleanArchitectureAPI.Domain.Entities;
using CleanArchitectureAPI.Domain.Interfaces;

namespace CleanArchitectureAPI.Application.Products.Commands;

// Command används för att ändra data (Create).
// IRequest<int> betyder att kommandot returnerar ett heltal (ID).
public record CreateProductCommand(string Name, decimal Price, int CategoryId) : IRequest<int>;

// Handler är klassen som utför själva logiken.
public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IRepository<Product> _repository;

    // Repository injiceras via Dependency Injection
    public CreateProductHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    // Denna metod körs när kommandot skickas via MediatR
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Skapar nytt Product-objekt
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        // Sparar i databasen
        await _repository.AddAsync(product);

        // Returnerar ID på skapad produkt
        return product.Id;
    }
}