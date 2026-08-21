namespace AshkanSocial.Application.DTOs;

public class RegisterUserResult
{
    public bool IsSuccess { get; init; }

    public string Message { get; init; } = string.Empty;

    public Guid? UserId { get; init; }

    public static RegisterUserResult Success(Guid userId)
    {
        return new RegisterUserResult
        {
            IsSuccess = true,
            Message = "Registration completed successfully.",
            UserId = userId
        };
    }

    public static RegisterUserResult Failure(string message)
    {
        return new RegisterUserResult
        {
            IsSuccess = false,
            Message = message
        };
    }
}
