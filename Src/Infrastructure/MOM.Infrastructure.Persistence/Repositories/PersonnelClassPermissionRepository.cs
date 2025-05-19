using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonnelClassPermissionRepository(ApplicationDbContext dbContext) : GenericRepository<PersonnelClassPermission>(dbContext), IPersonnelClassPermissionRepository
    {
        public async Task AddRangeAsync(List<string> menuButtonIds, Guid personnelClassDtId)
        {
            List<PersonnelClassPermission> personnelClassPermissions = new List<PersonnelClassPermission>();
            foreach (var item in menuButtonIds)
            {
                personnelClassPermissions.Add(new PersonnelClassPermission()
                {
                    MenuButtonId = item,
                    PersonnelClassDtId = personnelClassDtId,
                });
            }
            await DbSet.AddRangeAsync(personnelClassPermissions);
        }

        public void Delete(List<string> menuButtonIds, Guid personnelClassDtId)
        {
            DbSet.RemoveRange(DbSet.Where(m => m.PersonnelClassDtId == personnelClassDtId && menuButtonIds.Contains(m.MenuButtonId)));
        }

        public async Task<List<string>> GetByOwnerAsync(Guid owner)
        {
            return await DbSet.AsNoTracking().Where(m => m.PersonnelClassDtId == owner).Select(m => m.MenuButtonId).ToListAsync();
        }

        public Task<List<string>> GetPersonnelClassPermissionListAsync(Guid personnelClassDtId)
        {
            return DbSet.AsNoTracking().Where(m => m.PersonnelClassDtId == personnelClassDtId).Select(m => m.MenuButtonId).ToListAsync();
        }
        public Task<List<string>> GetPersonnelClassPermissionListAsync(IEnumerable<Guid> personnelClassDtIds)
        {
            return DbSet.AsNoTracking().Where(m => personnelClassDtIds.Contains(m.PersonnelClassDtId)).Select(m => m.MenuButtonId).Distinct().ToListAsync();
        }
    }
}
