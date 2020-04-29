using FluentValidation;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class EngineValidator : AbstractValidator<EngineDto>
    {

        public EngineValidator()
        {
            this.RuleFor(e => e.Name)
                .NotEmpty()
                .Length(1, 32)
                .WithMessage("Името трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(e => e.HorsePower)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Конските сили не могат да бъдат отрицателни!");
        }
    }
}
