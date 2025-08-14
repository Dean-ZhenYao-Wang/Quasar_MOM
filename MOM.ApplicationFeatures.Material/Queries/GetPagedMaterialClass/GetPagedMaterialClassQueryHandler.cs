using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.Material.Queries.GetPagedMaterialClass
{
    public class GetPagedMaterialClassQueryHandler(IMaterialClassRepository materialClassRepository) : IRequestHandler<GetPagedMaterialClassQuery, PagedResponse<MaterialClass>>
    {
        public async Task<PagedResponse<MaterialClass>> Handle(GetPagedMaterialClassQuery request, CancellationToken cancellationToken)
        {
            var query = materialClassRepository.Include(x => x.HierarchyScopeRel)
                .Include(x => x.IsAssembledFrom)
                .Include(x => x.IncludesPropertiesOf)
                .Where(x => !string.IsNullOrWhiteSpace(request.Id) ? x.Id == request.Id : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Name) ? x.Name.Contains(request.Name) : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Description) ? x.Description.Contains(request.Description) : true)
                .Where(x => request.HierarchyScopeRelDtId != null ? x.HierarchyScopeRelDtId == request.HierarchyScopeRelDtId.Value : true)
                .Where(x => request.IsAssembledFrom_SourceDtId != null ? x.IsAssembledFrom.Any(m => m.SourceId == request.IsAssembledFrom_SourceDtId) : true)
                .Where(x => request.IncludesPropertiesOf_SourceDtId != null ? x.IncludesPropertiesOf.Any(m => m.SourceId == request.IncludesPropertiesOf_SourceDtId) : true);

            return await materialClassRepository.PagedAsync(query, request.Page, request.PageSize);
        }
    }
}