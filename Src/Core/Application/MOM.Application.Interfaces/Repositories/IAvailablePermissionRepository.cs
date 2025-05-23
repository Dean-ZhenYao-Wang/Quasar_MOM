using MOM.Domain.Permission;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IAvailablePermissionRepository : IGenericRepository<AvailablePermission>
    {
        Task<List<AvailablePermission>> GetByOwnerAsync(Guid owner);
    }
}