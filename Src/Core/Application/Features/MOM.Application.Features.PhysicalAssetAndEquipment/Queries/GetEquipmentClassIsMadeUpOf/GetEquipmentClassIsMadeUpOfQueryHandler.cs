using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIsMadeUpOf
{
    public class GetEquipmentClassIsMadeUpOfQueryHandler(IEquipmentClassIsMadeUpOfRelationshipRepository equipmentClassIsMadeUpOfRelationshipRepository) : IRequestHandler<GetEquipmentClassIsMadeUpOfQuery, PagedResponse<EquipmentClass>>
    {
        public async Task<PagedResponse<EquipmentClass>> Handle(GetEquipmentClassIsMadeUpOfQuery request, CancellationToken cancellationToken)
        {
            var query = equipmentClassIsMadeUpOfRelationshipRepository
                .Include(m => m.Target)
                .Where(m => m.SourceId == request.DtId)
                .Select(m => m.Target);

            return await equipmentClassIsMadeUpOfRelationshipRepository.PagedAsync(query, request.Page, request.PageSize);
        }
    }
}