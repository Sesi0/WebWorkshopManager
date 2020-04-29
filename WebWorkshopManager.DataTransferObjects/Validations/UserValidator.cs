using FluentValidation;
using FluentValidation.Validators;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            this.RuleFor(u => u.Name)
                .NotEmpty()
                .Length(3, 32)
                .WithMessage("Потребителското име трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(u => u.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email адресът е невалиден!");
            this.RuleFor(u => u.Password)
                .NotEmpty()
                .MinimumLength(6)
                .WithMessage("Паролата трябва да съдържа минимум {MinLength} символа!");
            this.RuleFor(u => u.Role)
                .NotNull()
                .Must(r => r.RoleId > 0)
                .WithMessage("Не е избрана роля!");
        }
    }
}
