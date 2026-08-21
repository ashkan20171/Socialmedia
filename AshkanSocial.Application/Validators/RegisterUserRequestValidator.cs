using AshkanSocial.Application.DTOs;
using FluentValidation;

namespace AshkanSocial.Application.Validators;

public class RegisterUserRequestValidator
    : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserRequestValidator()
    {
        RuleFor(user => user.Username)
            .NotEmpty()
            .WithMessage("Username is required.")
            .MinimumLength(3)
            .WithMessage("Username must be at least 3 characters long.")
            .MaximumLength(50)
            .WithMessage("Username cannot exceed 50 characters.")
            .Matches("^[a-zA-Z0-9_]+$")
            .WithMessage(
                "Username can contain only English letters, numbers, and underscores.");

        RuleFor(user => user.DisplayName)
            .NotEmpty()
            .WithMessage("Display name is required.")
            .MinimumLength(2)
            .WithMessage("Display name must be at least 2 characters long.")
            .MaximumLength(100)
            .WithMessage("Display name cannot exceed 100 characters.");

        RuleFor(user => user.Password)
            .NotEmpty()
            .WithMessage("Password is required.")
            .MinimumLength(8)
            .WithMessage("Password must be at least 8 characters long.")
            .Matches("[A-Z]")
            .WithMessage("Password must contain at least one uppercase letter.")
            .Matches("[a-z]")
            .WithMessage("Password must contain at least one lowercase letter.")
            .Matches("[0-9]")
            .WithMessage("Password must contain at least one number.");

        RuleFor(user => user.ConfirmPassword)
            .Equal(user => user.Password)
            .WithMessage("Password confirmation does not match.");

        RuleFor(user => user.Email)
            .EmailAddress()
            .WithMessage("Please enter a valid email address.")
            .When(user => !string.IsNullOrWhiteSpace(user.Email));

        RuleFor(user => user.PhoneNumber)
            .MaximumLength(20)
            .WithMessage("Phone number cannot exceed 20 characters.")
            .When(user => !string.IsNullOrWhiteSpace(user.PhoneNumber));
    }
}
