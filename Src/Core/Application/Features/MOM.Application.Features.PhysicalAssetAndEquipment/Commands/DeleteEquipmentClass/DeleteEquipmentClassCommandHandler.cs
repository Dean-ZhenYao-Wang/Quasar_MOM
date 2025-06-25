using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipmentClass
{
    public class DeleteEquipmentClassCommandHandler(IEquipmentClassRepository equipmentClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteEquipmentClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteEquipmentClassCommand request, CancellationToken cancellationToken)
        {
            await equipmentClassRepository.DeleteRangeAsync(request.DtIds);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
