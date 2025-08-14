using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.Material.Queries.GetPagedMaterialDefinition
{
    public class GetPagedMaterialDefinitionQueryHandler(IMaterialDefinitionRepository materialDefinitionRepository) : IRequestHandler<GetPagedMaterialDefinitionQuery, PagedResponse<MaterialDefinition>>
    {
        public async Task<PagedResponse<MaterialDefinition>> Handle(GetPagedMaterialDefinitionQuery request, CancellationToken cancellationToken)
        {
            var query = materialDefinitionRepository.Include(x => x.HierarchyScopeRel)
                .Include(x => x.IsAssembledFrom)
                .Include(x => x.IsMemberOfClass)
                .Where(x => !string.IsNullOrWhiteSpace(request.Id) ? x.Id == request.Id : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Name) ? x.Name.Contains(request.Name) : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Description) ? x.Description.Contains(request.Description) : true)
                .Where(x => request.HierarchyScopeRelDtId != null ? x.HierarchyScopeRelDtId == request.HierarchyScopeRelDtId.Value : true)
                .Where(x => request.IsAssembledFrom_TargetDtId != null ? x.IsAssembledFrom.Any(m => m.TargetId == request.IsAssembledFrom_TargetDtId) : true)
                .Where(x => request.IsMemberOfClass_TargetDtId != null ? x.IsMemberOfClass.Any(m => m.TargetId == request.IsMemberOfClass_TargetDtId) : true)
                ;

            return await materialDefinitionRepository.PagedAsync(query, request.Page, request.PageSize);
        }
    }
}