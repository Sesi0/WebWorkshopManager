using FluentValidation;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class RoleValidator : AbstractValidator<RoleDto>
    {
        public RoleValidator()
        {
            this.RuleFor(r => r.Name)
                .NotEmpty().WithMessage("Името не може да е празно!")
                .Length(3, 32).WithMessage("Името трябва да съдържа от {MinLength} до {MaxLength} символа!");
        }
    }
}
