using FluentValidation;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        private const string phoneNumberRegEx = @"(\+|0{1})\d{9,13}";

        public CustomerValidator()
        {
            this.RuleFor(u => u.Name)
                .NotEmpty()
                .Length(3, 32)
                .WithMessage("Името трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(u => u.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email адресът е невалиден!");
            this.RuleFor(u => u.ContactNumber)
                .NotNull()
                .Matches(phoneNumberRegEx)
                .WithMessage("Номера за контакт не е валиден!");
        }
    }
}
