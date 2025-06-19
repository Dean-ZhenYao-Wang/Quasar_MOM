using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

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
            if (request.SourceDtId.HasValue)
                await personnelClassIncludesPropertiesOfRelationshipRepository.AddAsync(new Domain.Common.Relationship.isa95.PersonnelClass.PersonnelClassIncludesPropertiesOfRelationship(request.SourceDtId.Value, addClass.DtId));

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}