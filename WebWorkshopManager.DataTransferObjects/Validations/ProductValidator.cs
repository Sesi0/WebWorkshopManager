using FluentValidation;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            this.RuleFor(p => p.Name)
                .NotEmpty()
                .Length(2, 64)
                .WithMessage("Името трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(p => p.QuantityInStock)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Количеството не може да бъде отрицателно!");
            this.RuleFor(p => p.UnitPrice)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Цената не може да бъде отрицателна!");
        }
    }
}
