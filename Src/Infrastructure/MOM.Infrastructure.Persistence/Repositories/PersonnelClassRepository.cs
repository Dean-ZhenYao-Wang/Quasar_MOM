using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonnelClassRepository(ApplicationDbContext dbContext) : GenericRepository<PersonnelClass>(dbContext), IPersonnelClassRepository
    {
        public async Task DeleteAsync(Guid[] dtIds)
        {
            using var transaction = await dbContext.Database.BeginTransactionAsync();
            try
            {
                await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
                await dbContext.Set<PersonnelClassIncludesPropertiesOfRelationship>()
                    .Where(m => dtIds.Contains(m.SourceId.Value))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));
                await dbContext.Set<PersonnelClassHasPropertiesOfRelationship>()
                    .Where(m => dtIds.Contains(m.DtId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));
                await dbContext.Set<PersonnelClassHierarchyScopeRelRelationship>()
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
    }
}
