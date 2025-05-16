using Azure.Core;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class OrgPermissionRepository(ApplicationDbContext dbContext) : GenericRepository<OrgPermission>(dbContext), IOrgPermissionRepository
    {
        public void Delete(List<string> menuButtonIds, Guid orgDtId)
        {
            DbSet.RemoveRange(DbSet.Where(m => m.OrgDtId == orgDtId && menuButtonIds.Contains(m.MenuButtonId)));
        }

        public Task<List<string>> GetOrgPermissionListAsync(Guid orgDtId)
        {
            return DbSet.AsNoTracking().Where(m=>m.OrgDtId==orgDtId).Select(m=>m.MenuButtonId).ToListAsync();
        }

        public async Task AddRangeAsync(List<string> menuButtonIds, Guid orgDtId)
        {
            List<OrgPermission> orgPermissions = new List<OrgPermission>();
            foreach (var item in menuButtonIds)
            {
                orgPermissions.Add(new OrgPermission()
                {
                    MenuButtonId = item,
                    OrgDtId = orgDtId,
                });
            }
            await DbSet.AddRangeAsync(orgPermissions);
        }
    }
}
