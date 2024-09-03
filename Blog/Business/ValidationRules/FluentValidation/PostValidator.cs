using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Fill Content")
                .MinimumLength(150);
            
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Not Empty")
                .MinimumLength(15); ;

          
           
            RuleFor(x => x.Author)
                .NotEmpty()
                .WithMessage("Not Empty");
        }
    }
}
