using AshkanSocial.Application.DTOs;
using AshkanSocial.Application.Features.Auth.Login;

namespace AshkanSocial.Application.Abstractions;

public interface IUserService
{
    Task<RegisterUserResult> RegisterAsync(
        RegisterUserRequest request,
        CancellationToken cancellationToken = default);

    Task<LoginResult> LoginAsync(
        LoginRequest request,
        CancellationToken cancellationToken = default);
}
