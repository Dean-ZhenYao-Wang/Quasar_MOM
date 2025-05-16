using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetButtonList
{
    public class GetButtonListQuery : IRequest<BaseResult<List<ButtonResponse>>>
    {
        public Guid? ParentMenuDtId { get; set; }
        public string? ParentMenuId { get; set; }
    }
}
