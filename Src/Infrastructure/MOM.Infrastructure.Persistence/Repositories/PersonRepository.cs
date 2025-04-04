using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonRepository(ApplicationDbContext dbContext) : GenericRepository<Person>(dbContext), IPersonRepository
    {
        private readonly DbSet<Person> person = dbContext.Set<Person>();
        private readonly DbSet<PersonnelClass> personnelClass = dbContext.Set<PersonnelClass>();
        /// <summary>
        /// 获取负责人下拉列表数据，此处默认获取全部人员，可根据客户需求进行定制（增加数据过滤条件）
        /// </summary>
        /// <returns></returns>
        public async Task<List<Person>> GetResponsiblesAsync()
        {
            return await person.Where(m => m.IsDelete == false).AsNoTracking().ToListAsync();
        }
        public async Task<PaginationResponseDto<PersonResponse>> GetPagedListAsync(int pageNumber,int pageSize)
        {
            var query = person.Where(m => m.IsDelete == false)
                .OrderBy(m => m.Created)
                .Select(m => new PersonResponse()
                {
                    DtId = m.DtId,
                    Id = m.Id,
                    Name = m.Name,
                    WorkStatus = m.WorkStatus,
                    Description = m.Description,
                    Email = m.Email,
                    PhoneNumber = m.PhoneNumber,
                    TeamOfGroupDtId = personnelClass.Where(c => c.Id.Equals("TeamOfGroup"))
                    .Select(c => c.IncludesPropertiesOf.Where(i => m.DefinedBy.Select(d => d.TargetId).Contains(i.DtId)).Select(i => i.Target).FirstOrDefault())
                    .FirstOrDefault().DtId,
                    DepartmentDtId = personnelClass.Where(c => c.Id.Equals("Department"))
                    .Select(c => c.IncludesPropertiesOf.Where(i => m.DefinedBy.Select(d => d.TargetId).Contains(i.DtId)).Select(i => i.Target).FirstOrDefault())
                    .FirstOrDefault().DtId,//Position
                    PositionDtId_List = personnelClass.Where(c => c.Id.Equals("Position"))
                    .Select(c => c.IncludesPropertiesOf.Where(i => m.DefinedBy.Select(d => d.TargetId).Contains(i.DtId)).Select(i => i.Target.DtId))
                    .FirstOrDefault(),
                    //Properties = m.HasValuesOf.Select(v => new MOM.Application.DTOs.Resource.ResourcePropertyViewModel(v.Target))  前端要单独通过调用接口获取
                });
            return await PagedAsync(query, pageNumber, pageSize);
        }
    }
}
