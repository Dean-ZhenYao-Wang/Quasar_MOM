using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.Equipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipment
{
    public class DeleteEquipmentCommandHandler(IEquipmentRepository equipmentRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteEquipmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteEquipmentCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await equipmentRepository.DeleteRangeAsync(request.DtIds);
                unitOfWork.DbContext.Set<EquipmentDefinedByRelationship>().RemoveRange(
                    unitOfWork.DbContext.Set<EquipmentDefinedByRelationship>()
                        .Where(x => request.DtIds.Contains(x.SourceId) || request.DtIds.Contains(x.TargetId))
                );
                await unitOfWork.SaveChangesAsync();
                await transaction.CommitAsync();
                return BaseResult.Ok();

            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
