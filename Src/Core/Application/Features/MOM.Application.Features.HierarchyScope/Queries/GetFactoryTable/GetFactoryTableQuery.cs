using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Queries.GetFactoryTable
{
    public class GetFactoryTableQuery : IRequest<PagedResponse<OrgResponse>>
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 要查看的页数
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 每页展示条数
        /// </summary>
        public int PageSize { get; set; }
    }
}