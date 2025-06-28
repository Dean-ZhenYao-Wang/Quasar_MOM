using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipment
{
    public class GetPagedEquipmentQuery :
        MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests.GetPagedEquipmentRequest
        , IRequest<PagedResponse<Equipment>>
    {
    }
    public class GetPagedEquipmentQueryHandler(IEquipmentRepository equipmentProperty) : IRequestHandler<GetPagedEquipmentQuery, PagedResponse<Equipment>>
    {
        public async Task<PagedResponse<Equipment>> Handle(GetPagedEquipmentQuery request, CancellationToken cancellationToken)
        {
            var query = equipmentProperty.Include(x => x.HierarchyScopeRel)
                .Include(x => x.DefinedBy)
                .ThenInclude(d => d.Target)
                .Include(x => x.Responsible)
                .Where(x => !string.IsNullOrWhiteSpace(request.Id) ? x.Id.Contains(request.Id) : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Name) ? x.Name.Contains(request.Name) : true)
                .Where(x => request.EquipmentLevel.HasValue ? x.EquipmentLevel == request.EquipmentLevel : true)
                .Where(x => request.HierarchyScopeRelDtId.HasValue ? x.HierarchyScopeRelDtId == request.HierarchyScopeRelDtId : true)
                .Where(x => request.DefinedByDtId.HasValue ? x.DefinedBy.Any(d => d.TargetId == request.DefinedByDtId.Value) : true)
                .Where(x => request.Status.HasValue ? x.Status == request.Status : true);

            return await equipmentProperty.PagedAsync(query, request.Page, request.PageSize);
        }
    }
}
