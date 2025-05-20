using MediatR;
using MOM.Application.DTOs.PersonnelClass.Requests;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition
{
    public class GetPagedTeamQuery :IRequest<PagedResponse<TeamResponse>>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 所属班组的DtId
        /// </summary>
        public Guid? sourceDtId { get; set; }

        PaginationRequestParameter paginationRequestParameter = new PaginationRequestParameter();
        /// <summary>
        /// 要查看的页数：从1开始数
        /// </summary>
        public int PageNumber { get{ return paginationRequestParameter.PageNumber; } set{ paginationRequestParameter.PageNumber = value; } }
        /// <summary>
        /// 每页显示数据条数
        /// </summary>
        public int PageSize { get { return paginationRequestParameter.PageSize; } set { paginationRequestParameter.PageSize = value; } }
    }
}
