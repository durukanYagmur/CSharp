using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(2).WithMessage("Car name must contain at least 2 char");
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
