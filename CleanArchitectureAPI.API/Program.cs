using Microsoft.EntityFrameworkCore;
using CleanArchitectureAPI.Infrastructure.Data;
using CleanArchitectureAPI.Domain.Interfaces;
using CleanArchitectureAPI.Infrastructure.Repositories;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Registrerar DbContext och kopplar till SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrerar Repository för Dependency Injection
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Registrerar MediatR och pekar på Application-lagret
builder.Services.AddMediatR(Assembly.Load("CleanArchitectureAPI.Application"));

// Lägger till Controllers
builder.Services.AddControllers();

// Aktiverar Swagger (API-dokumentation)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktiverar Swagger i webbläsaren
app.UseSwagger();
app.UseSwaggerUI();

// Mappar controllers
app.MapControllers();

app.Run();
