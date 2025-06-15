using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;

namespace MOM.Application.Features.Personnel.Queries.GetPagedListPerson
{
    public class GetPagedPersonQueryHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork) : IRequestHandler<GetPagedPersonQuery, PagedResponse<PersonResponse>>
    {
        public async Task<PagedResponse<PersonResponse>> Handle(GetPagedPersonQuery request, CancellationToken cancellationToken)
        {
            var query = personRepository.AsNoTracking()
                .Include(p => p.DefinedBy)
                .ThenInclude(d => d.Target)
                .ThenInclude(t => t.Permissions)
                .Include(p => p.HierarchyScopeRel)
                .ThenInclude(t => t.Permissions)
                .Where(p => !string.IsNullOrWhiteSpace(request.Id) ? p.Id.Contains(request.Id) : true)
                .Where(p => !string.IsNullOrWhiteSpace(request.Name) ? p.Name.Contains(request.Name) : true)
                .Where(p => request.WorkStatus.HasValue ? p.WorkStatus == request.WorkStatus.Value : true)
                .Where(p => !string.IsNullOrWhiteSpace(request.Email) ? p.ContactInformation.Email.Contains(request.Email) : true)
                .Where(p => !string.IsNullOrWhiteSpace(request.PhoneNumber) ? p.ContactInformation.PhoneNumber.Contains(request.PhoneNumber) : true)
                .Where(p => request.TeamOfGroupDtId.HasValue ? p.DefinedBy.Any(d => d.TargetId == request.TeamOfGroupDtId.Value) : true)
                .Where(p => request.PositionDtId.HasValue ? p.DefinedBy.Any(d => d.TargetId == request.PositionDtId.Value) : true)
                .Where(p => request.OrgDtId.HasValue ? p.HierarchyScopeRelDtId == request.OrgDtId : true)
                .OrderBy(p => p.Id)
                .Select(p => new PersonResponse
                {
                    DtId = p.DtId,
                    Id = p.Id,
                    Name = p.Name,
                    WorkStatus = p.WorkStatus,
                    Description = p.Description,
                    Email = p.ContactInformation.Email,
                    PhoneNumber = p.ContactInformation.PhoneNumber,
                    Team = p.DefinedBy.Where(d => d.Target.Description.Equals("班组")).Select(d => new ResponseObject { DtId = d.Target.DtId, Label = d.Target.Id }).FirstOrDefault(),
                    Org = new ResponseObject { DtId = p.HierarchyScopeRelDtId, Label = p.HierarchyScope },
                    PositionList = p.DefinedBy.Where(d => d.Target.Description.Equals("职位")).Select(d => new ResponseObject { DtId = d.Target.DtId, Label = d.Target.Id }),
                    DefinedByPermissions = p.DefinedBy.SelectMany(d => d.Target.Permissions.Select(perm => perm.MenuButtonId)),
                    HierarchyScopeRelPermissions = p.HierarchyScopeRel.Permissions.Select(perm => perm.MenuButtonId),
                    AvailablePermissions = p.AvailablePermissions.Select(ap => new AvailablePerm { Available = ap.Available, MenuButtonId = ap.MenuButtonId })
                });

            return await personRepository.PagedAsync(query, request.PageNumber, request.PageSize);
        }
    }
}