using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeRepository : IGenericRepository<HierarchyScope>
    {
        Task DeleteAsync(Guid[] dtIds);
    }
}