using MediatR;
using CleanArchitectureAPI.Domain.Entities;
using CleanArchitectureAPI.Domain.Interfaces;

namespace CleanArchitectureAPI.Application.Products.Queries;

// Query används för att hämta data (Read).
public record GetAllProductsQuery() : IRequest<List<Product>>;

// Handler som hanterar queryn.
public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IRepository<Product> _repository;

    public GetAllProductsHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    // Hämtar alla produkter från databasen
    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
