using Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AutValidator : AbstractValidator<RegisterDto>
    {
        public AutValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress().MinimumLength(10);
            RuleFor(x => x.FullName).NotEmpty().MinimumLength(10);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(10).NotNull().MaximumLength(20);
        }
    }
}
