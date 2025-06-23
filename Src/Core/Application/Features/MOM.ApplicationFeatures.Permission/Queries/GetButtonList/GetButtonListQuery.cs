using MediatR;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Queries.GetButtonList
{
    /// <summary>
    ///
    /// </summary>
    public class GetButtonListQuery : IRequest<BaseResult<List<ButtonResponse>>>
    {
        /// <summary>
        ///
        /// </summary>
        public Guid? ParentMenuDtId { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string? ParentMenuId { get; set; }
    }
}