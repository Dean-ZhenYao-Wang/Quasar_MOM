using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition
{
    public class GetPagedPositionQueryHandler(IPersonnelClassRepository personnelClassRepository) : IRequestHandler<GetPagedPositionQuery, PagedResponse<PersonnelClassResponse>>
    {
        public async Task<PagedResponse<PersonnelClassResponse>> Handle(GetPagedPositionQuery request, CancellationToken cancellationToken)
        {
            var query = personnelClassRepository
                .Where(m => m.Description.Equals("职位"))
                .Where(x => !string.IsNullOrWhiteSpace(request.Id) && x.Id.Contains(request.Id))
                .Where(x => !string.IsNullOrWhiteSpace(request.Remark) && x.Remark.Contains(request.Remark))
                .AsQueryable()
                .Include(x => x.Permissions)
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
