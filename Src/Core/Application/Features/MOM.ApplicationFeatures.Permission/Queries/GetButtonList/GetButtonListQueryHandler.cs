using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetButtonList
{
    public class GetButtonListQueryHandler(IButtonRepository buttonRepository) : IRequestHandler<GetButtonListQuery, BaseResult<List<ButtonResponse>>>
    {
        public async Task<BaseResult<List<ButtonResponse>>> Handle(GetButtonListQuery request, CancellationToken cancellationToken)
        {
            var query = buttonRepository.DbSet
                .Include(m => m.Menu)
                .AsNoTracking();

            if (request.ParentMenuDtId != null)
                query = query.Where(m => m.MenuDtId == request.ParentMenuDtId);

            if (!string.IsNullOrWhiteSpace(request.ParentMenuId))
                query = query.Where(m => m.Menu.Id.Equals(request.ParentMenuId));

            return await query
                .Select(m => new ButtonResponse
                {
                    DtId = m.DtId,
                    Id = m.Id,
                    Name = m.Name,
                    Icon = m.Icon,
                    MenuDtId = m.MenuDtId,
                }).ToListAsync();
        }
    }
}