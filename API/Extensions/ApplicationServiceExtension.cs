using API.Data;
using API.Interfaces;
using API.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<DataContext>(options =>
            options.UseSqlite(config.GetConnectionString("DefaultConnection")));

        services.AddFluentValidationAutoValidation()
            .AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssemblyContaining<Program>();

        return services;
    }
}