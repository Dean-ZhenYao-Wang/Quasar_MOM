using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Department.Responses;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IPersonnelClassRepository : IGenericRepository<PersonnelClass>
    {
        Task DeleteAsync(Guid[] dtIds);
        Task<List<DepartmentResponse>> GetDepartmentTreeAsync(Guid? sourceDtId);
    }
}
