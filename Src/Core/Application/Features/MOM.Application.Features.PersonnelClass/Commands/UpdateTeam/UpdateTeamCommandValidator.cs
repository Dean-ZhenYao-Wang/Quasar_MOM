using FluentValidation;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdateTeam
{

    public class UpdateTeamCommandValidator : AbstractValidator<UpdateTeamCommand>
    {
        public UpdateTeamCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty()
                .WithName(p => translator[nameof(p.Id)]);
        }
    }
}
