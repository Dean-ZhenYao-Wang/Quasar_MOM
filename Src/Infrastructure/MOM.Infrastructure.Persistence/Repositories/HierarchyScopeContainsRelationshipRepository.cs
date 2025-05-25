using Azure.Core;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class HierarchyScopeContainsRelationshipRepository(ApplicationDbContext dbContext) : GenericRepository<HierarchyScopeContainsRelationship>(dbContext), IHierarchyScopeContainsRelationshipRepository
    {
        public async Task AddAsync(Guid? parentId, HierarchyScope newNode)
        {
            var closureRows = new List<HierarchyScopeContainsRelationship>();
            if (parentId != null)
            {
                var ancestors = await this
                    .Where(c => c.TargetId == parentId)
                    .ToListAsync();

                foreach (var a in ancestors)
                {
                    closureRows.Add(new HierarchyScopeContainsRelationship(a.SourceId, newNode, a.Depth + 1));
                }

                closureRows.Add(new HierarchyScopeContainsRelationship(parentId, newNode, closureRows.Last().Depth + 1));

            }
            else
            {
                closureRows.Add(new HierarchyScopeContainsRelationship(parentId, newNode, 0));
            }
            newNode.Depth = closureRows.Last().Depth;

            await this.AddRangeAsync(closureRows);

            await this.SaveChangesAsync();

            // 自身->自身路径
            await UpdateFullPathAsync(newNode.DtId);

            await this.SaveChangesAsync();
        }
        /// <summary>
        /// 更新自身路径
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task UpdateFullPathAsync(Guid nodeId)
        {
            var path = await GetFullPathAsync(nodeId);

            var node = await this.Include(m => m.Target)
                .Where(m => m.TargetId == nodeId).Select(m => m.Target).FirstOrDefaultAsync();
            if (node != null)
            {
                if (string.IsNullOrWhiteSpace(path))
                {
                    node.FullPath = node.Name; // 如果没有路径，则使用节点名称作为路径
                }
                else
                {
                    node.FullPath = path + "/" + node.Name;
                }
            }

            // 可递归更新所有子节点 FullPath（建议缓存）
            var children = await this
                .Where(c => c.SourceId == nodeId && c.TargetId != nodeId)
                .Select(c => c.TargetId)
                .ToListAsync();

            foreach (var childId in children)
            {
                await UpdateFullPathAsync(childId);
            }
        }
        /// <summary>
        /// 查询祖先路径
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task<string> GetFullPathAsync(Guid nodeId)
        {
            var names = await this
                .Where(c => c.TargetId == nodeId && c.SourceId != null)
                .OrderBy(c => c.Depth)
                .Select(c => c.Source.Name)
                .ToListAsync();

            return string.Join("/", names);
        }
        /// <summary>
        /// 移动节点（变更上级）
        /// </summary>
        /// <param name="nodeId">要移动的节点</param>
        /// <param name="newParentId">新的父节点，null 表示根节点</param>
        public async Task MoveNodeAsync(Guid nodeId, Guid? newParentId)
        {
            // 逻辑删除旧路径
            var oldPaths = await this
                .Where(c => c.TargetId == nodeId || c.SourceId == nodeId)
                .ToListAsync();
            oldPaths.ForEach(old => old.IsDelete = true);

            var newPaths = new List<HierarchyScopeContainsRelationship>();

            // 获取新父的所有祖先
            var newAncestors = await this
                .Where(c => c.TargetId == newParentId)
                .OrderBy(c => c.Depth)
                .Select(c => new { SourceId = c.SourceId, Depth = c.Depth })
                .ToListAsync();
            newAncestors.Add(new { SourceId = newParentId, Depth = newAncestors.Count > 0 ? newAncestors.Last().Depth + 1 : 0 });

            // 获取所有后代（包括自己）
            var descendants = await this
                .Where(c => c.SourceId == nodeId)
                .Select(c => new { c.TargetId, c.Depth })
                .ToListAsync();
            descendants.Add(new { TargetId = nodeId, Depth = 0 }); // 包括自己

            foreach (var ancestor in newAncestors)
            {
                foreach (var desc in descendants)
                {
                    newPaths.Add(new HierarchyScopeContainsRelationship(
                        ancestor.SourceId,
                        desc.TargetId,
                        ancestor.Depth + 1 + desc.Depth
                    ));
                }
            }

            await this.AddRangeAsync(newPaths);
            await this.SaveChangesAsync();

            // 一次性更新所有新路径涉及的 Target 节点路径缓存
            var affectedNodeIds = descendants.Select(d => d.TargetId);
            foreach (var id in affectedNodeIds)
            {
                await UpdateFullPathAsync(id);
            }
        }




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


    }
}