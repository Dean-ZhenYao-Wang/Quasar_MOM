using MediatR;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.AddTeam
{
    public class AddTeamCommandHandler(IPersonnelClassRepository personnelClassRepository,
        IPersonnelClassIncludesPropertiesOfRelationshipRepository personnelClassIncludesPropertiesOfRelationshipRepository, 
        IUnitOfWork unitOfWork) : IRequestHandler<AddTeamCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddTeamCommand request, CancellationToken cancellationToken)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass addClass = request.ToPersonnelClass("班组");

            await personnelClassRepository.AddAsync(addClass);

            await personnelClassIncludesPropertiesOfRelationshipRepository.AddAsync(new Domain.Common.Relationship.isa95.PersonnelClass.PersonnelClassIncludesPropertiesOfRelationship(request.SourceDtId, addClass.DtId));

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
