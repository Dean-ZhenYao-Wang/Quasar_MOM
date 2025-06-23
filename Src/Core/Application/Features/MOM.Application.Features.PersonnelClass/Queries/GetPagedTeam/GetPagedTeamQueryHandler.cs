using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition
{
    public class GetPagedTeamQueryHandler(IPersonnelClassIncludesPropertiesOfRelationshipRepository personnelClassIncludesPropertiesOfRelationshipRepository, IPersonnelClassPermissionRepository personnelClassPermissionRepository) : IRequestHandler<GetPagedTeamQuery, PagedResponse<TeamResponse>>
    {
        public async Task<PagedResponse<TeamResponse>> Handle(GetPagedTeamQuery request, CancellationToken cancellationToken)
        {
            var query = personnelClassIncludesPropertiesOfRelationshipRepository
                .Include(navigation => navigation.Target)
                .ThenInclude(t => t.Responsible)
                .Include(navigation => navigation.Target)
                .ThenInclude(t => t.Permissions)
                .Include(navigation => navigation.Target)
                .ThenInclude(t => t.HierarchyScopeRel)
                .Where(m => m.Target.Description.Equals("班组"))
                .Where(x => request.sourceDtId != null ? x.SourceId == request.sourceDtId : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Id) ? x.Target.Id.Contains(request.Id) : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Remark) ? x.Target.Remark.Contains(request.Remark) : true)
                .Select(x => new TeamResponse
                {
                    DtId = x.Target.DtId,
                    Id = x.Target.Id,
                    Remark = x.Target.Remark,
                    ResponsibleDtId = x.Target.ResponsibleDtId,
                    ResponsibleName = x.Target.ResponsibleDtId == null ? null : x.Target.Responsible.Name,
                    SourceDtId = x.SourceId,
                    SourceName = x.Source == null ? string.Empty : x.Source.Id,
                    Permissions = x.Target.Permissions.Select(p => p.MenuButtonId),
                    OrgDtId = x.Target.HierarchyScopeRelDtId,
                    OrgName = x.Target.HierarchyScope,
                });

            return await personnelClassIncludesPropertiesOfRelationshipRepository.PagedAsync(query, request.PageNumber, request.PageSize);
        }
    }
}