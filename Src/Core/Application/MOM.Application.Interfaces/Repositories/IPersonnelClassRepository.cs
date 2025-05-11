using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IPersonnelClassRepository : IGenericRepository<PersonnelClass>
    {
        Task AddAsync(PersonnelClass model, Guid? sourceDtId);
        Task DeleteAsync(Guid[] dtIds);
    }
}