using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetMenuList
{
    public class GetMenuListQuery : IRequest<BaseResult<List<MenuResponse>>>
    {
        /// <summary>
        /// 所属组织DtId
        /// </summary>
        public Guid? ParentMenuDtId { get; set; }

        /// <summary>
        /// 菜单编号
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string? Name { get; set; }
    }
}