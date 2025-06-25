using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIncludesRelations
{
    public class GetEquipmentClassIncludesRelationsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetEquipmentClassIncludesRelationsQuery, List<EquipmentClass>>
    {
        public async Task<List<EquipmentClass>> Handle(GetEquipmentClassIncludesRelationsQuery request, CancellationToken cancellationToken)
        {
            return unitOfWork.DbContext.Set<EquipmentClassIncludesPropertiesOfRelationship>()
                .Include(m => m.Target)
                .Where(m => m.SourceId == request.DtId)
                .Select(m => m.Target)
                .ToList();
        }
    }
}