using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetMenuList
{
    public class GetMenuListQueryHandler(IMenuRepository menuRepository) : IRequestHandler<GetMenuListQuery, BaseResult<List<MenuResponse>>>
    {
        public async Task<BaseResult<List<MenuResponse>>> Handle(GetMenuListQuery request, CancellationToken cancellationToken)
        {
            return await menuRepository.DbSet.Where(m => m.ParentMenuDtId == request.ParentMenuDtId)
                .Where(m => !string.IsNullOrWhiteSpace(request.Id) ? m.Id.Contains(request.Id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(request.Name) ? m.Name.Contains(request.Name) : true)
                .OrderBy(m => m.Id)
                .Select(m => new MenuResponse
                {
                    Id = m.Id,
                    Name = m.Name,
                    Path = m.Path,
                    DtId = m.DtId,
                    ParentMenuDtId = m.ParentMenuDtId,
                    Description = m.Description,
                    Icon = m.Icon,
                    Hidden = m.Hidden,
                    AlwaysShow = m.AlwaysShow,
                    Depth = m.Depth,
                    IsChild = m.Children.Any()
                }).AsNoTracking().ToListAsync();
        }
    }
}
