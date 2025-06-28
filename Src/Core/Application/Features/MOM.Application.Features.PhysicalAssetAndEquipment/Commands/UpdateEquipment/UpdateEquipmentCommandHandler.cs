using MediatR;
using MOM.Application.DTOs.PhysicalAssetAndEquipment;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommandHandler(IEquipmentRepository equipmentRepository, IEquipmentDefinedByRelationshipRepository equipmentDefinedByRelationshipRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateEquipmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateEquipmentCommand request, CancellationToken cancellationToken)
        {
            var old = equipmentRepository.Include(x => x.DefinedBy).Where(x => x.DtId == request.DtId).FirstOrDefault();

            foreach (var item in request.DefinedByDtId.Where(m => !old.DefinedByDtId.Contains(m)))
            {
                await equipmentDefinedByRelationshipRepository.AddAsync(new Domain.Common.Relationship.isa95.Equipment.EquipmentDefinedByRelationship(old.DtId, item));
            }
            old.Update(request);

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }

    }
}
