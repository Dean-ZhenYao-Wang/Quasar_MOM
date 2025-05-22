using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Queries.GetPagedListPerson
{
    public class GetPagedPersonQueryHandler(IPersonRepository personRepository) : IRequestHandler<GetPagedPersonQuery, PagedResponse<PersonResponse>>
    {
        public async Task<PagedResponse<PersonResponse>> Handle(GetPagedPersonQuery request, CancellationToken cancellationToken)
        {
            var query = personRepository.AsNoTracking()
                .Include(p => p.DefinedBy)
                .ThenInclude(d => d.Target)
                .Include(p => p.HierarchyScopeRel)
                .ThenInclude(h => h.Target)
                .Where(p => !string.IsNullOrWhiteSpace(request.Id) ? p.Id.Contains(request.Id) : true)
                .Where(p => !string.IsNullOrWhiteSpace(request.Name) ? p.Name.Contains(request.Name) : true)
                .Where(p => request.WorkStatus.HasValue ? p.WorkStatus == request.WorkStatus.Value : true)
                .Where(p => !string.IsNullOrWhiteSpace(request.Email) ? p.ContactInformation.Email.Contains(request.Email) : true)
                .Where(p => !string.IsNullOrWhiteSpace(request.PhoneNumber) ? p.ContactInformation.PhoneNumber.Contains(request.PhoneNumber) : true)
                .Where(p => request.TeamOfGroupDtId.HasValue ? p.DefinedBy.Any(d => d.TargetId == request.TeamOfGroupDtId.Value) : true)
                .Where(p => request.PositionDtId.HasValue ? p.DefinedBy.Any(d => d.TargetId == request.PositionDtId.Value) : true)
                .Where(p => request.OrgDtId.HasValue ? p.HierarchyScopeRel.Any(d => d.TargetId == request.OrgDtId) : true)
                .Select(p => new PersonResponse
                {
                    DtId = p.DtId,
                    Id = p.Id,
                    Name = p.Name,
                    WorkStatus = p.WorkStatus,
                    Description = p.Description,
                    Email = p.ContactInformation.Email,
                    PhoneNumber = p.ContactInformation.PhoneNumber,
                    Team = p.DefinedBy.Where(d => d.Target.Description.Equals("班组")).Select(d => new ResponseObject { DtId = d.Target.DtId, Id = d.Target.Id }).FirstOrDefault(),
                    Org = p.HierarchyScopeRel.Where(d => d.Target.Description.Equals("组织")).Select(d => new ResponseObject { DtId = d.Target.DtId, Id = d.Target.Id }).FirstOrDefault(),
                    PositionList = p.DefinedBy.Where(d => d.Target.Description.Equals("职位")).Select(d => new ResponseObject { DtId = d.Target.DtId, Id = d.Target.Id })
                });

            return await personRepository.PagedAsync(query, request.Page, request.PageSize);
        }
    }
}