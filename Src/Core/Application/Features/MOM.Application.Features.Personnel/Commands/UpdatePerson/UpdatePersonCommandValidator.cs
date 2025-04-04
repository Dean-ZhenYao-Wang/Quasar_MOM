using FluentValidation;
using MOM.Application.Interfaces;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.UpdatePerson
{
    public class UpdatePersonCommandValidator : AbstractValidator<UpdatePersonCommand>
    {
        public UpdatePersonCommandValidator(ITranslator translator)
        {

            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100)
                .WithName(p => translator[nameof(p.Name)]);
        }
    }

}
