using MOM.Domain.Permission;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IButtonRepository : IGenericRepository<Button>
    {
        Task DeleteAsync(Guid[] dtIds);

        Task<List<Button>> GetButtonsByMenuIdAsync(Guid menuDtId);
    }
}