using Microsoft.EntityFrameworkCore;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IPersonnelClassRepository : IGenericRepository<PersonnelClass>
    {
        Task DeleteAsync(Guid[] dtIds);
    }
}
