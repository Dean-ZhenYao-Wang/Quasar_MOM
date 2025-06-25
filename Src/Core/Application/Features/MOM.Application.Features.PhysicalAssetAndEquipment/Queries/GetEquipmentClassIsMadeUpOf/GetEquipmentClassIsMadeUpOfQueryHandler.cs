using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIsMadeUpOf
{
    public class GetEquipmentClassIsMadeUpOfQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetEquipmentClassIsMadeUpOfQuery, List<EquipmentClass>>
    {
        public async Task<List<EquipmentClass>> Handle(GetEquipmentClassIsMadeUpOfQuery request, CancellationToken cancellationToken)
        {
            return unitOfWork.DbContext.Set<EquipmentClassIsMadeUpOfRelationship>()
                .Include(m => m.Target)
                .Where(m => m.SourceId == request.DtId)
                .Select(m => m.Target)
                .ToList();
        }
    }
}