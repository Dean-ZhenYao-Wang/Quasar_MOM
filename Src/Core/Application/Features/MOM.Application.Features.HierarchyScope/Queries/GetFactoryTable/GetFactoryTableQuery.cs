using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetFactoryTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetFactoryTableQuery : PaginationRequestParameter,IRequest<PagedResponse<OrgResponse>>
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }
    }
}