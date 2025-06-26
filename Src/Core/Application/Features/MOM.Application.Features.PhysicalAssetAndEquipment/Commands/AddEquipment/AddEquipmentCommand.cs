using MediatR;
using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipmentClass;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipment
{
    public class AddEquipmentCommand : AddEquipmentRequest, IRequest<BaseResult>
    {
    }
}
