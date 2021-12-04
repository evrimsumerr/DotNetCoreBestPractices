using BP.Api.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Api.Validations
{
    public class ContactValidator : AbstractValidator<ContactDVO>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Id).LessThan(100).WithMessage("Id 100'den büyük olamaz.");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id 0'dan küçük olamaz.");
        }
    }
}
