using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipmentClass
{
    public class UpdateEquipmentClassCommandHandler(IEquipmentClassRepository equipmentClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateEquipmentClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateEquipmentClassCommand request, CancellationToken cancellationToken)
        {
            var old = equipmentClassRepository.Where(x => x.DtId == request.DtId).FirstOrDefault();
            if(!string.IsNullOrEmpty(request.Id))
                old.Id = request.Id;
            old.Name = request.Name;
            old.Property = request.Property;
            old.Description = request.Description;
            old.HierarchyScopeRelDtId = request.HierarchyScopeRelDtId;
            old.EquipmentLevel = request.EquipmentLevel;

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
