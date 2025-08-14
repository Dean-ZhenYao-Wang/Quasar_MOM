using MediatR;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.Material.Queries.GetPagedMaterialClass
{
    public class GetPagedMaterialClassQuery :
        DTOs.PhysicalAssetAndEquipment.Requests.GetPagedEquipmentClassRequest
        , IRequest<PagedResponse<MaterialClass>>
    {
    }
}