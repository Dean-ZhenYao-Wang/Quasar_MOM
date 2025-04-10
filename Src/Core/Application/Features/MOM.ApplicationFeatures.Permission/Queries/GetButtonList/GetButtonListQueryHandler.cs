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
            return await buttonRepository.DbSet.Where(m => m.MenuDtId == request.ParentMenuDtId)
                .Select(m => new ButtonResponse
                {
                    DtId = m.DtId,
                    Id = m.Id,
                    Name = m.Name,
                    Icon = m.Icon,
                    MenuDtId = m.MenuDtId,
                }).AsNoTracking().ToListAsync();
        }
    }
}
