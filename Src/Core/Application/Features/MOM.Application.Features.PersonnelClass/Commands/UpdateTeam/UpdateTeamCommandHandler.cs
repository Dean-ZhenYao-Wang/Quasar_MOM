using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdateTeam
{
    public class UpdateTeamCommandHandler(IPersonnelClassRepository personnelClassRepository, IPersonnelClassIncludesPropertiesOfRelationshipRepository personnelClassIncludesPropertiesOfRelationshipRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateTeamCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            var position = await personnelClassRepository.GetByIdAsync(request.DtId);
            if (position == null)
            {
                return BaseResult.Failure(new Error(ErrorCode.NotFound, "Position not found."));
            }
            position.Id = request.Id;
            position.Remark = request.Remark;
            position.ResponsibleDtId = request.ResponsibleDtId;
            position.HierarchyScopeRelDtId = request.OrgDtId;
            // Update other properties as needed
            personnelClassRepository.Update(position);

            var oldSource = personnelClassIncludesPropertiesOfRelationshipRepository
                .Where(m => m.TargetId.Equals(request.DtId))
                .FirstOrDefault();
            if (oldSource != null && oldSource.SourceId != request.SourceDtId)
            {
                oldSource.IsDelete = false;
            }
            else
            {
                if (request.SourceDtId != null)
                {
                    await personnelClassIncludesPropertiesOfRelationshipRepository.AddAsync(new Domain.Common.Relationship.isa95.PersonnelClass.PersonnelClassIncludesPropertiesOfRelationship(request.SourceDtId, request.DtId));
                }
            }

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}