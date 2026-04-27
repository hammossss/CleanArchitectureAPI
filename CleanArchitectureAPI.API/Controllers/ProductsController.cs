using Microsoft.AspNetCore.Mvc;
using MediatR;
using CleanArchitectureAPI.Application.Products.Commands;
using CleanArchitectureAPI.Application.Products.Queries;

namespace CleanArchitectureAPI.API.Controllers;

// Route: api/products
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    // MediatR injiceras via Dependency Injection
    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET api/products
    // Hämtar alla produkter
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _mediator.Send(new GetAllProductsQuery());
        return Ok(products);
    }

    // POST api/products
    // Skapar en ny produkt
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        var id = await _mediator.Send(command);
        return Ok(id);
    }
}
