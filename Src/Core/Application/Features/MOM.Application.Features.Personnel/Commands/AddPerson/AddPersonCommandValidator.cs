using FluentValidation;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommandValidator : AbstractValidator<AddPersonCommand>
    {
        public AddPersonCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.UserName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator[nameof(p.UserName)]);

            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator[nameof(p.Name)]);
        }
    }
}