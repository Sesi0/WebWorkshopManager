using System;
using FluentValidation;
using WebWorkshopManager.Shared.ENUMS;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Shared.Validations
{
    public class JobValidator : AbstractValidator<JobDto>
    {
        private readonly UserValidator userValidator = new UserValidator();
        private readonly CustomerValidator customerValidator = new CustomerValidator();
        private readonly CarValidator carValidator = new CarValidator();

        public JobValidator()
        {
            this.RuleFor(j => j.Status)
                .NotNull()
                .WithMessage("Не е избран статус!")
                .NotEqual(JOB_STATUS.NONE)
                .WithMessage("Не е избран статус!");

            this.RuleFor(j => j.Worker)
                .SetValidator(this.userValidator)
                .WithMessage("Не е избран работник!");

            this.RuleFor(j => j.Customer)
                .SetValidator(this.customerValidator)
                .WithMessage("Не е избран клиент!");

            this.RuleFor(j => j.Car)
                .SetValidator(this.carValidator)
                .WithMessage("Не е избран автомобил!");
        }
    }
}
