using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
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
        private readonly DbSet<PersonnelClassIncludesPropertiesOfRelationship> personnelClassIncludesPropertiesOfRelationships = dbContext.Set<PersonnelClassIncludesPropertiesOfRelationship>();
        private readonly DbSet<PersonnelClassHierarchyScopeRelRelationship> personnelClassHierarchyScopeRelRelationships = dbContext.Set<PersonnelClassHierarchyScopeRelRelationship>();

        public async Task AddAsync(Guid sourceDtId, PersonnelClass model)
        {
            await AddAsync(model);
            await personnelClassIncludesPropertiesOfRelationships.AddAsync(new PersonnelClassIncludesPropertiesOfRelationship(sourceDtId, model.DtId));
        }

        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
        }
    }
}