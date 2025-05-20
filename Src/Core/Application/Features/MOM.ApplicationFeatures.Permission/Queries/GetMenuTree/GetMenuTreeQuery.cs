using MediatR;
using MOM.Application.DTOs.Menu.Responses;

namespace MOM.Application.Features.Permission.Queries.GetMenuTree
{
    /// <summary>
    /// 菜单管理页面获得所有菜单树
    /// </summary>
    public class GetMenuTreeQuery : IRequest<List<MenuTreeNodeResponse>>
    { }
}