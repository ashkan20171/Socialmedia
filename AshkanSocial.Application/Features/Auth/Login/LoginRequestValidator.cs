using FluentValidation;

namespace AshkanSocial.Application.Features.Auth.Login;

public sealed class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.UsernameOrEmail)
            .NotEmpty()
            .WithMessage("Username or email is required.")
            .MaximumLength(150)
            .WithMessage("Username or email must not exceed 150 characters.");

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required.")
            .MaximumLength(100)
            .WithMessage("Password must not exceed 100 characters.");
    }
}
