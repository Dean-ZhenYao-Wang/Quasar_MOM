using MediatR;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Queries.GetEnterpriseTable
{
    /// <summary>
    ///
    /// </summary>
    public class GetEnterpriseTableQuery : PaginationRequestParameter,IRequest<PagedResponse<OrgResponse>>
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
    }
}