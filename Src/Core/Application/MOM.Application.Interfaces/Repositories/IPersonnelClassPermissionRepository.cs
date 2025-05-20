using MOM.Domain.Permission;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IPersonnelClassPermissionRepository : IGenericRepository<PersonnelClassPermission>
    {
        Task AddRangeAsync(List<string> menuButtonIds, Guid personnelClassDtId);

        void Delete(List<string> menuButtonIds, Guid personnelClassDtId);

        Task<List<string>> GetByOwnerAsync(Guid owner);

        Task<List<string>> GetPersonnelClassPermissionListAsync(Guid personnelClassDtId);

        Task<List<string>> GetPersonnelClassPermissionListAsync(IEnumerable<Guid> personnelClassDtIds);
    }
}