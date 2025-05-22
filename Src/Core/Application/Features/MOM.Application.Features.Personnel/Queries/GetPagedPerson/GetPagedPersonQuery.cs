using MediatR;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;

namespace MOM.Application.Features.Personnel.Queries.GetPagedListPerson
{
    public class GetPagedPersonQuery : PaginationRequestParameter, IRequest<PagedResponse<PersonResponse>>
    {
        /// <summary>
        /// UserName 账号 工号
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public PersonWorkStatus? WorkStatus { get; set; } 

        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 班组
        /// </summary>
        public Guid? TeamOfGroupDtId { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public Guid? PositionDtId { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Guid? OrgDtId { get; set; }
    }
}