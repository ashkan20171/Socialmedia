namespace AshkanSocial.Application.DTOs;

public class RegisterUserRequest
{
    public string Username { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string ConfirmPassword { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }
}
