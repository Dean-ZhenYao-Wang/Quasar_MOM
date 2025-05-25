using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeRepository : IGenericRepository<HierarchyScope>
    {
        Task DeleteAsync(Guid[] dtIds);
        Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string? id, string? name, int page, int pageSize);
    }
}