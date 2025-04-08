using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetMenuList
{
    public class GetMenuListQuery : IRequest<BaseResult<List<MenuResponse>>>
    {
        public Guid? ParentMenuDtId { get; set; }
    }
}
