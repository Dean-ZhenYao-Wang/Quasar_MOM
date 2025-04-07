using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
