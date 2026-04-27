# CleanArchitectureAPI

## Description
This project is an ASP.NET Core Web API built using Clean Architecture principles.

The project demonstrates:
- Clean Architecture (4 layers)
- CQRS pattern
- MediatR
- Repository Pattern
- Entity Framework Core
- SQL Server
- Swagger documentation

## Project Structure

- CleanArchitectureAPI.API → Presentation Layer
- CleanArchitectureAPI.Application → Application Layer (CQRS, MediatR)
- CleanArchitectureAPI.Domain → Domain Layer (Entities, Interfaces)
- CleanArchitectureAPI.Infrastructure → Infrastructure Layer (EF Core, Repository)

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (SQLEXPRESS)
- MediatR
- Swagger

## Database

Connection string is configured for:

DESKTOP-UK1F352\SQLEXPRESS

Database name:
CleanArchitectureAPIDb

## How to Run

1. Run migrations:
   dotnet ef database update -p CleanArchitectureAPI.Infrastructure -s CleanArchitectureAPI.API

2. Run the API:
   dotnet run --project CleanArchitectureAPI.API

3. Open Swagger:
   https://localhost:xxxx/swagger

## Architecture Pattern

The project follows Clean Architecture:
- Domain has no dependencies.
- Application depends only on Domain.
- Infrastructure depends on Domain and Application.
- API depends on Application.

CQRS is implemented using MediatR.
