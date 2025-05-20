using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces.Repositories;

namespace MOM.Application.Features.Permission.Queries.GetMenuTree
{
    public class GetMenuTreeQueryHandler(IMenuRepository menuRepository) : IRequestHandler<GetMenuTreeQuery, List<MenuTreeNodeResponse>>
    {
        public async Task<List<MenuTreeNodeResponse>> Handle(GetMenuTreeQuery request, CancellationToken cancellationToken)
        {
            return await menuRepository.GetMenuTreeAsync();
        }
    }
}