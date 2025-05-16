using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class HierarchyScopeRepository(ApplicationDbContext dbContext) : GenericRepository<HierarchyScope>(dbContext), IHierarchyScopeRepository
    {
        private readonly DbSet<HierarchyScopeContainsRelationship> hierarchyScopeContainsRelationship = dbContext.Set<HierarchyScopeContainsRelationship>();

        public async Task AddAsync(HierarchyScope model, Guid? sourceDtId)
        {
            await AddAsync(model);
            await hierarchyScopeContainsRelationship.AddAsync(new HierarchyScopeContainsRelationship(sourceDtId, model.DtId));
        }

        public async Task DeleteAsync(Guid[] dtIds)
        {
            using var transaction = await dbContext.Database.BeginTransactionAsync();
            try
            {
                await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
                await hierarchyScopeContainsRelationship
                    .Where(m => dtIds.Contains(m.SourceId.Value) || dtIds.Contains(m.TargetId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }

        public async Task<List<TreeNode<OrgResponse>>> GetOrgTreeAsync(Guid? sourceDtId)
        {
            List<TreeNode<OrgResponse>> returnModel = null;

            var queryList = await hierarchyScopeContainsRelationship
                .AsNoTracking()
                .Include(m => m.Target)
                .ThenInclude(m => m.Contains)
                .ThenInclude(m => m.Target)
                .OrderBy(m => m.Id)
                .ToListAsync();

            returnModel = BuildTree(queryList, sourceDtId);

            return returnModel;
        }

        public List<TreeNode<OrgResponse>> BuildTree(List<HierarchyScopeContainsRelationship> queryList, Guid? sourceDtId)
        {
            var roots = queryList
                .Where(m => m.SourceId == sourceDtId)
                .Select(m => m.Target.ToOrgTreeResponse(sourceDtId))
                .ToList();
            foreach (var root in roots)
            {
                root.children = BuildTree(queryList, root.data.DtId);
            }
            return roots;
        }

        public async Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string id, string name, int page, int pageSize)
        {
            var query = hierarchyScopeContainsRelationship
                    .AsNoTracking()
                    .Include(m => m.Source)
                    .Include(m => m.Target)
                    .Where(m => sourceDtId != null ? m.SourceId == sourceDtId : true)
                    .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Target.Id.Contains(id) : true)
                    .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Target.Name.Contains(name) : true)
                    .Select(m => m.Target.ToOrgItemResponse(m.SourceId, m.SourceId != null ? m.Source.Name : string.Empty));

            return await PagedAsync(query, page, pageSize);
        }
    }
}
