using MediatR;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass
{
    public class GetPagedEquipmentClassQuery :
        MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests.GetPagedEquipmentClassRequest
        , IRequest<PagedResponse<EquipmentClass>>
    {
    }
}