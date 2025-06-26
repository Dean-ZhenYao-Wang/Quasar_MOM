using MediatR;
using MOM.Application.DTOs.PhysicalAssetAndEquipment;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommandHandler(IEquipmentRepository equipmentRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateEquipmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateEquipmentCommand request, CancellationToken cancellationToken)
        {
            var old = equipmentRepository.Where(x => x.DtId == request.DtId).FirstOrDefault();
            old.Update(request);

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }

    }
}
