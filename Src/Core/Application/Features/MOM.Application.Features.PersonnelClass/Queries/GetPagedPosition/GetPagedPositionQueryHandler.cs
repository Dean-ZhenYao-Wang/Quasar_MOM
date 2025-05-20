using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition
{
    public class GetPagedPositionQueryHandler(IPersonnelClassRepository personnelClassRepository) : IRequestHandler<GetPagedPositionQuery, PagedResponse<PersonnelClassResponse>>
    {
        public async Task<PagedResponse<PersonnelClassResponse>> Handle(GetPagedPositionQuery request, CancellationToken cancellationToken)
        {
            var query = personnelClassRepository.DbSet
                .Include(x => x.Permissions)
                .Where(x => x.Description.Equals("职位"))
                .Where(x => !string.IsNullOrWhiteSpace(request.Id) ? x.Id.Contains(request.Id) : true)
                .Where(x => !string.IsNullOrWhiteSpace(request.Remark) ? x.Remark.Contains(request.Remark) : true)
                .Select(x => new PersonnelClassResponse
                {
                    DtId = x.DtId,
                    Id = x.Id,
                    Remark = x.Remark,
                    Permissions = x.Permissions.Select(p => p.MenuButtonId)
                });

            return await personnelClassRepository.PagedAsync(query, request.PageNumber, request.PageSize);
        }
    }
}