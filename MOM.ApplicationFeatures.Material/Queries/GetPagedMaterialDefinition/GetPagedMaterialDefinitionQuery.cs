using MediatR;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.Material.Queries.GetPagedMaterialDefinition
{
    public class GetPagedMaterialDefinitionQuery :
        DTOs.MaterialDefinition.Requests.GetPagedMaterialDefinitionRequest
        , IRequest<PagedResponse<MaterialDefinition>>
    {
    }
}