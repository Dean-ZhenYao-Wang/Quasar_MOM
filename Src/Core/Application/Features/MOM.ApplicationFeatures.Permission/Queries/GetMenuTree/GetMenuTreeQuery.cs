using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Queries.GetMenuTree
{
    /// <summary>
    /// 菜单管理页面获得所有菜单树
    /// </summary>
    public class GetMenuTreeQuery : IRequest<List<MenuTreeNodeResponse>> { }
}
