using Data.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.UserName).MinimumLength(10);
            RuleFor(x => x.FullName).MinimumLength(10);
            RuleFor(x => x.FullName).NotEmpty();
        }
    }
}
