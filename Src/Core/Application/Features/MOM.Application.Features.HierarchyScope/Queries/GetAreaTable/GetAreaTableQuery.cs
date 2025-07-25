using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetWorkshopTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetAreaTableQuery : PaginationRequestParameter, IRequest<PagedResponse<OrgResponse>>
    {
        /// <summary>
        /// 上级编号
        /// </summary>
        public Guid? SourceDtId { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool? Active { get; set; }
    }
}