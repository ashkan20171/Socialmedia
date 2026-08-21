using AshkanSocial.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AshkanSocial.Application.Abstractions;
using AshkanSocial.Application.Validators;
using AshkanSocial.Infrastructure.Services;


namespace AshkanSocial.Infrastructure.DependencyInjection;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        string? connectionString =
            configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException(
                "Connection string 'DefaultConnection' was not found.");
        }

        services.AddDbContext<AshkanSocialDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<RegisterUserRequestValidator>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
