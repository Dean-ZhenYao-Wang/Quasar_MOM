using FluentValidation;
using MediatR;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommandValidator : AbstractValidator<AddPersonCommand>
    {
        public AddPersonCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator[nameof(p.Id)]);

            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator[nameof(p.Name)]);
        }
    }
}
