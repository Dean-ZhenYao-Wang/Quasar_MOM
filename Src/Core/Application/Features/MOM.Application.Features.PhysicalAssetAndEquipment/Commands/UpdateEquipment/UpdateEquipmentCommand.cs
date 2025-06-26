using MediatR;
using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommand : UpdateEquipmentRequest, IRequest<BaseResult>
    {
    }
}
