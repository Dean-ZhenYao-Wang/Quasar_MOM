using FluentValidation;
using MOM.Application.Wrappers;

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