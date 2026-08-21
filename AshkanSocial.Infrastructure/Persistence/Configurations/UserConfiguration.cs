using AshkanSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AshkanSocial.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.Id)
            .ValueGeneratedNever();

        builder.Property(user => user.Username)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(user => user.Username)
            .IsUnique();

        builder.Property(user => user.DisplayName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(user => user.PasswordHash)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(user => user.Email)
            .HasMaxLength(150);

        builder.HasIndex(user => user.Email)
            .IsUnique()
            .HasFilter("[Email] IS NOT NULL");

        builder.Property(user => user.PhoneNumber)
            .HasMaxLength(20);

        builder.HasIndex(user => user.PhoneNumber)
            .IsUnique()
            .HasFilter("[PhoneNumber] IS NOT NULL");

        builder.Property(user => user.Bio)
            .HasMaxLength(500);

        builder.Property(user => user.ProfileImagePath)
            .HasMaxLength(500);

        builder.Property(user => user.IsActive)
            .HasDefaultValue(true)
            .IsRequired();

        builder.Property(user => user.CreatedAtUtc)
            .IsRequired();

        builder.Property(user => user.LastSeenAtUtc);
    }
}
