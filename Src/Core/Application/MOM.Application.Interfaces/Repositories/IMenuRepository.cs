using MOM.Application.DTOs.Menu.Responses;
using MOM.Domain.Permission;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IMenuRepository : IGenericRepository<Menu>
    {
        Task DeleteAsync(Guid[] dtIds);

        Task<Guid[]> GetButtonDtIdsAsync(Guid[] dtIds);

        Task<List<MenuTreeNodeResponse>> GetMenuTreeAsync();
    }
}