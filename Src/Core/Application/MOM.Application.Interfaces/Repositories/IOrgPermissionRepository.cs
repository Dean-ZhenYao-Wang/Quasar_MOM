using MOM.Domain.Permission;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IOrgPermissionRepository : IGenericRepository<OrgPermission>
    {
        Task AddRangeAsync(List<string> menuButtonIds, Guid orgDtId);

        void Delete(List<string> menuButtonIds, Guid orgDtId);

        Task<List<string>> GetOrgPermissionListAsync(Guid orgDtId);
    }
}