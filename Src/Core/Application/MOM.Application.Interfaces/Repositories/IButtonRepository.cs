using MOM.Domain.Permission;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IButtonRepository : IGenericRepository<Button>
    {
        Task<List<Button>> GetButtonsByMenuIdAsync(Guid menuDtId);
    }
}
