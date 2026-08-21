using AshkanSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AshkanSocial.Infrastructure.Persistence;

public class AshkanSocialDbContext : DbContext
{
    public AshkanSocialDbContext(DbContextOptions<AshkanSocialDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AshkanSocialDbContext).Assembly);
    }
}
