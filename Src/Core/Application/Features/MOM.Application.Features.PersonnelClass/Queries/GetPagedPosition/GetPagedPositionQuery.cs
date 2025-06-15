using MediatR;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition
{
    public class GetPagedPositionQuery : IRequest<PagedResponse<PersonnelClassResponse>>
    {
        /// <summary>
        /// 职位名称
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }

        private PaginationRequestParameter paginationRequestParameter = new PaginationRequestParameter();

        /// <summary>
        /// 要查看的页数：从1开始数
        /// </summary>
        public int PageNumber
        { get { return paginationRequestParameter.PageNumber; } set { paginationRequestParameter.PageNumber = value; } }

        /// <summary>
        /// 每页显示数据条数
        /// </summary>
        public int PageSize
        { get { return paginationRequestParameter.PageSize; } set { paginationRequestParameter.PageSize = value; } }
    }
}