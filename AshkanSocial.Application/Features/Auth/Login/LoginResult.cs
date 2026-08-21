namespace AshkanSocial.Application.Features.Auth.Login;

public sealed class LoginResult
{
    public bool IsSuccess { get; init; }

    public string Message { get; init; } = string.Empty;

    public Guid? UserId { get; init; }

    public string? Username { get; init; }

    public string? DisplayName { get; init; }

    public static LoginResult Success(
        Guid userId,
        string username,
        string displayName)
    {
        return new LoginResult
        {
            IsSuccess = true,
            Message = "Login successful.",
            UserId = userId,
            Username = username,
            DisplayName = displayName
        };
    }

    public static LoginResult Failure(string message)
    {
        return new LoginResult
        {
            IsSuccess = false,
            Message = message
        };
    }
}
