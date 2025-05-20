using FluentValidation;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdatePosition
{
    public class UpdatePositionCommandValidator : AbstractValidator<UpdatePositionCommand>
    {
        public UpdatePositionCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty()
                .WithName(p => translator[nameof(p.Id)]);
        }
    }
}