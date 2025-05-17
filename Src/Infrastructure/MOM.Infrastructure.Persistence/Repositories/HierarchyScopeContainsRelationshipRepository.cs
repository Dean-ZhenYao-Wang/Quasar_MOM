using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class HierarchyScopeContainsRelationshipRepository(ApplicationDbContext dbContext) : GenericRepository<HierarchyScopeContainsRelationship>(dbContext), IHierarchyScopeContainsRelationshipRepository
    {

        public async Task<List<TreeNode<OrgResponse>>> GetOrgTreeAsync(Guid? sourceDtId)
        {
            List<TreeNode<OrgResponse>> returnModel = null;

            var queryList = await this.DbSet.AsNoTracking()
                .Include(m => m.Target)
                .ThenInclude(m => m.Contains)
                .ThenInclude(m => m.Target)
                .OrderBy(m => m.Id)
                .ToListAsync();

            returnModel = BuildTree(queryList, sourceDtId);

            return returnModel;
        }

        private List<TreeNode<OrgResponse>> BuildTree(List<HierarchyScopeContainsRelationship> queryList, Guid? sourceDtId)
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
            var query = this.DbSet
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
