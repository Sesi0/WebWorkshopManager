using System;
using FluentValidation;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class CarValidator : AbstractValidator<CarDto>
    {
        private const string vinRegEx = @"^(?=.*[0-9])(?=.*[A-z])[0-9A-z-]{17}$";
        private const string engineNumberRegEx = @"^[A-z]{3}[0-9]{6}$";
        private const int firstMadeCarYear = 1886;

        public CarValidator()
        {
            this.RuleFor(c => c.Brand)
                .NotEmpty()
                .Length(1, 16)
                .WithMessage("Марката трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(c => c.Model)
                .NotEmpty()
                .Length(1, 32)
                .WithMessage("Марката трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(c => c.Mileage)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Пробега не може да е отрицателен!");
            this.RuleFor(c => c.Engine)
                .NotNull()
                .WithMessage("Не е добавен двигател");
            this.RuleFor(c => c.LicensePlate)
                .Length(6, 8)
                .WithMessage("Регистрационният номер трябва да съдържа от {MinLength} до {MaxLength} символа!");
            this.RuleFor(c => c.Vin)
                .NotEmpty()
                .Matches(vinRegEx)
                .WithMessage("VIN номерът е невалиден! (Валиден може да е следния пример: WVWZZZ1JZ3W584008)");
            this.RuleFor(c => c.Year)
                .GreaterThanOrEqualTo(firstMadeCarYear)
                .WithMessage("Годината трябва да е по-голяма от {ComparisonValue}!");
            this.RuleFor(c => c.Year)
                .LessThanOrEqualTo(DateTime.Now.Year)
                .WithMessage("Годината не може да е по-голяма от {ComparisonValue}!");
            this.RuleFor(c => c.EngineNumber)
                .Matches(engineNumberRegEx)
                .When(c => !string.IsNullOrEmpty(c.EngineNumber))
                .WithMessage("Невалиден номер на двигател! (Валиден може да е следния пример: ATD496532)");

        }
    }
}
