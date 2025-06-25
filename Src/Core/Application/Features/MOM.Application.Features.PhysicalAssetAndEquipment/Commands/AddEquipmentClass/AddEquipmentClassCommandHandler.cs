using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipmentClass
{
    public class AddEquipmentClassCommandHandler(IEquipmentClassRepository equipmentClassRepository, IUnitOfWork unitOfWork,IMediator mediator) : IRequestHandler<AddEquipmentClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddEquipmentClassCommand request, CancellationToken cancellationToken)
        {
            var equipmentClass = request.ToEquipmentClass();
            equipmentClass.Id = string.IsNullOrWhiteSpace(request.Id)
                    ? await mediator.Send(new GenerateCodeCommand { RuleId = "EquipmentClassId", ModelTypeName = " MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass,MOM.Domain" })
                    : request.Id;
            await equipmentClassRepository.AddAsync(equipmentClass);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
