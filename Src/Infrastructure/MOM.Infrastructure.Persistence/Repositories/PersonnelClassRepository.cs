using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Department;
using MOM.Application.DTOs.Department.Responses;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonnelClassRepository(ApplicationDbContext dbContext) : GenericRepository<PersonnelClass>(dbContext), IPersonnelClassRepository
    {
        private readonly DbSet<PersonnelClassIncludesPropertiesOfRelationship> personnelClassIncludesPropertiesOfRelationships = dbContext.Set<PersonnelClassIncludesPropertiesOfRelationship>();
        private readonly DbSet<PersonnelClassHasPropertiesOfRelationship> personnelClassHasPropertiesOfRelationships = dbContext.Set<PersonnelClassHasPropertiesOfRelationship>();
        private readonly DbSet<PersonnelClassHierarchyScopeRelRelationship> personnelClassHierarchyScopeRelRelationships = dbContext.Set<PersonnelClassHierarchyScopeRelRelationship>();
        public async Task DeleteAsync(Guid[] dtIds)
        {
            using var transaction = await dbContext.Database.BeginTransactionAsync();
            try
            {
                await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
                await personnelClassIncludesPropertiesOfRelationships
                    .Where(m => dtIds.Contains(m.SourceId.Value))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));
                await personnelClassHasPropertiesOfRelationships
                    .Where(m => dtIds.Contains(m.DtId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));
                await personnelClassHierarchyScopeRelRelationships
                    .Where(m => dtIds.Contains(m.DtId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }

        public async Task<List<DepartmentResponse>> GetDepartmentTreeAsync(Guid? sourceDtId)
        {
            List<DepartmentResponse> returnModel = null;

            if (sourceDtId != null && sourceDtId != Guid.Empty)
            {
                returnModel = await personnelClassIncludesPropertiesOfRelationships.Where(m => m.SourceId == sourceDtId.Value)
                    .Select(m => m.Target.ToDepartmentResponse())
                    .ToListAsync();
            }
            else
            {
                returnModel = await this.DbSet.Where(m => m.Description.Equals("部门")
                &&
                    !personnelClassHierarchyScopeRelRelationships.Where(r=>r.TargetId==m.DtId).Any())
                     .Select(m => m.ToDepartmentResponse())
                     .ToListAsync();
            }


            return returnModel;
        }
    }
}
