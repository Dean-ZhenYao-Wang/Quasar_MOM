using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.Person;
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
        private readonly DbSet<PersonnelClass> personnelClass = dbContext.Set<PersonnelClass>();

        /// <summary>
        /// 获取负责人下拉列表数据，此处默认获取全部人员，可根据客户需求进行定制（增加数据过滤条件）
        /// </summary>
        /// <returns></returns>
        public Task<List<Person>> GetResponsiblesAsync()
        {
            return this.AsNoTracking().Where(m => m.IsDelete == false).ToListAsync();
        }

        public Task<PagedResponse<PersonResponse>> GetPagedListAsync(int pageNumber, int pageSize)
        {
            var query = this.Where(m => m.IsDelete == false)
                .OrderBy(m => m.Created)
                .Select(m => new PersonResponse()
                {
                    DtId = m.DtId,
                    Id = m.Id,
                    Name = m.Name,
                    WorkStatus = m.WorkStatus,
                    Description = m.Description,
                    Email = m.ContactInformation.Email,
                    PhoneNumber = m.ContactInformation.PhoneNumber,
                    //TeamOfGroupDtId = personnelClass.Where(c => c.Id.Equals("TeamOfGroup"))
                    //.Select(c => c.IncludesPropertiesOf.Where(i => m.DefinedBy.Select(d => d.TargetId).Contains(i.DtId)).Select(i => i.Target).FirstOrDefault())
                    //.FirstOrDefault().DtId,
                    //OrgDtId = personnelClass.Where(c => c.Id.Equals("Org"))
                    //.Select(c => c.IncludesPropertiesOf.Where(i => m.DefinedBy.Select(d => d.TargetId).Contains(i.DtId)).Select(i => i.Target).FirstOrDefault())
                    //.FirstOrDefault().DtId,//Position
                    //PositionDtId_List = personnelClass.Where(c => c.Id.Equals("Position"))
                    //.Select(c => c.IncludesPropertiesOf.Where(i => m.DefinedBy.Select(d => d.TargetId).Contains(i.DtId)).Select(i => i.Target.DtId))
                    //.FirstOrDefault(),
                    //Properties = m.HasValuesOf.Select(v => new MOM.Application.DTOs.Resource.ResourcePropertyViewModel(v.Target))  前端要单独通过调用接口获取
                }).AsQueryable();
            return this.PagedAsync(query, pageNumber, pageSize);
        }

        public async Task<Person> FindByNameAsync(string userName)
        {
            return await this.DbSet.Where(m => m.Id.Equals(userName))
                .Include(m => m.DefinedBy)
                .ThenInclude(d => d.Target)
                .FirstOrDefaultAsync();
        }

        public async Task DeleteAsync(Guid[] dtIds)
        {
            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), m => m.SetProperty(m => m.IsDelete, true));
                await dbContext.Set<PersonDefinedByRelationship>().Where(m => dtIds.Contains(m.TargetId)).ExecuteUpdateAsync(m => m.SetProperty(p => p.IsDelete, true));
                await tran.CommitAsync();
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
            }
        }
    }
}