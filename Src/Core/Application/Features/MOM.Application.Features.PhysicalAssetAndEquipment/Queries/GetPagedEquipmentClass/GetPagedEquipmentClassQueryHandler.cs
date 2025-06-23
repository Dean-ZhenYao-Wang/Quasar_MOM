using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass
{
    public class GetPagedEquipmentClassQueryHandler(IEquipmentClassRepository equipmentClassProperty) : IRequestHandler<GetPagedEquipmentClassQuery, PagedResponse<EquipmentClass>>
    {
        public async Task<PagedResponse<EquipmentClass>> Handle(GetPagedEquipmentClassQuery request, CancellationToken cancellationToken)
        {
            var query = equipmentClassProperty.Include(x => x.HierarchyScopeRel)
                .Where(x => !string.IsNullOrWhiteSpace(request.Name) ? x.Name.Contains(request.Name) : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Description) ? x.Description.Contains(request.Description) : true)
                .Where(x => request.HierarchyScopeRelDtId.HasValue ? x.HierarchyScopeRelDtId == request.HierarchyScopeRelDtId : true)
                .Where(x => request.EquipmentLevel.HasValue ? x.EquipmentLevel == request.EquipmentLevel : true);

            return await equipmentClassProperty.PagedAsync(query, request.Page, request.PageSize);
        }
    }
}