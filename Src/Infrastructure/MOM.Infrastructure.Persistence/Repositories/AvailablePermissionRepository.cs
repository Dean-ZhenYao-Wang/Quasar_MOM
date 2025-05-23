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
    public class AvailablePermissionRepository(ApplicationDbContext dbContext) : GenericRepository<AvailablePermission>(dbContext), IAvailablePermissionRepository
    {
        public async Task<List<AvailablePermission>> GetByOwnerAsync(Guid owner)
        {
            return await this.DbSet.Where(m => m.PersonDtId == owner).ToListAsync();
        }
    }
}