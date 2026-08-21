using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AshkanSocial.Infrastructure.Persistence;

public class DesignTimeDbContextFactory
    : IDesignTimeDbContextFactory<AshkanSocialDbContext>
{
    public AshkanSocialDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(
                path: "appsettings.json",
                optional: false,
                reloadOnChange: false)
            .Build();

        string? connectionString =
            configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException(
                "Connection string 'DefaultConnection' was not found in appsettings.json.");
        }

        DbContextOptions<AshkanSocialDbContext> options =
            new DbContextOptionsBuilder<AshkanSocialDbContext>()
                .UseSqlServer(connectionString)
                .Options;

        return new AshkanSocialDbContext(options);
    }
}
