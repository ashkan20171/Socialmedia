using AshkanSocial.Application.Abstractions;
using AshkanSocial.Application.DTOs;
using AshkanSocial.Application.Features.Auth.Login;
using AshkanSocial.Application.Validators;
using AshkanSocial.Domain.Entities;
using AshkanSocial.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace AshkanSocial.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly AshkanSocialDbContext _dbContext;
    private readonly RegisterUserRequestValidator _registerValidator;
    private readonly LoginRequestValidator _loginValidator;

    public UserService(
        AshkanSocialDbContext dbContext,
        RegisterUserRequestValidator registerValidator,
        LoginRequestValidator loginValidator)
    {
        _dbContext = dbContext;
        _registerValidator = registerValidator;
        _loginValidator = loginValidator;
    }

    public async Task<LoginResult> LoginAsync(
        LoginRequest request,
        CancellationToken cancellationToken = default)
    {
        var validationResult = await _loginValidator.ValidateAsync(
            request,
            cancellationToken);

        if (!validationResult.IsValid)
        {
            string message = string.Join(
                Environment.NewLine,
                validationResult.Errors.Select(error => error.ErrorMessage));

            return LoginResult.Failure(message);
        }

        // Username و Email در RegisterAsync به صورت lowercase ذخیره شده‌اند.
        string normalizedUsernameOrEmail = request.UsernameOrEmail
            .Trim()
            .ToLowerInvariant();

        var user = await _dbContext.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(
                user =>
                    user.Username == normalizedUsernameOrEmail ||
                    (user.Email != null &&
                     user.Email == normalizedUsernameOrEmail),
                cancellationToken);

        // یک پیام عمومی برای جلوگیری از افشای وجود داشتن حساب.
        if (user is null)
        {
            return LoginResult.Failure(
                "Invalid username, email, or password.");
        }

        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(
            request.Password,
            user.PasswordHash);

        if (!isPasswordValid)
        {
            return LoginResult.Failure(
                "Invalid username, email, or password.");
        }

        if (!user.IsActive)
        {
            return LoginResult.Failure(
                "This account is currently inactive.");
        }

        return LoginResult.Success(
            user.Id,
            user.Username,
            user.DisplayName);
    }

    public async Task<RegisterUserResult> RegisterAsync(
        RegisterUserRequest request,
        CancellationToken cancellationToken = default)
    {
        var validationResult = await _registerValidator.ValidateAsync(
            request,
            cancellationToken);

        if (!validationResult.IsValid)
        {
            string message = string.Join(
                Environment.NewLine,
                validationResult.Errors.Select(error => error.ErrorMessage));

            return RegisterUserResult.Failure(message);
        }

        string normalizedUsername = request.Username.Trim().ToLowerInvariant();

        string normalizedEmail = string.IsNullOrWhiteSpace(request.Email)
            ? string.Empty
            : request.Email.Trim().ToLowerInvariant();

        bool usernameExists = await _dbContext.Users
            .AnyAsync(
                user => user.Username == normalizedUsername,
                cancellationToken);

        if (usernameExists)
        {
            return RegisterUserResult.Failure(
                "This username is already taken.");
        }

        if (!string.IsNullOrWhiteSpace(normalizedEmail))
        {
            bool emailExists = await _dbContext.Users
                .AnyAsync(
                    user => user.Email == normalizedEmail,
                    cancellationToken);

            if (emailExists)
            {
                return RegisterUserResult.Failure(
                    "This email address is already registered.");
            }
        }

        User user = new()
        {
            Id = Guid.NewGuid(),
            Username = normalizedUsername,
            DisplayName = request.DisplayName.Trim(),
            Email = string.IsNullOrWhiteSpace(normalizedEmail)
                ? null
                : normalizedEmail,
            PhoneNumber = string.IsNullOrWhiteSpace(request.PhoneNumber)
                ? null
                : request.PhoneNumber.Trim(),
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            IsActive = true,
            CreatedAtUtc = DateTime.UtcNow
        };

        _dbContext.Users.Add(user);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return RegisterUserResult.Success(user.Id);
    }
}
