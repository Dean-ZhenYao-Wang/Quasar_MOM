using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class RelationshipRepository<T, TSource, TTarget>(DbContext dbContext)
    : GenericRepository<T>(dbContext),
      IRelationshipRepository<T, TSource, TTarget>
         where T : Relationship<TSource, TTarget>, new()
            where TSource : BaseEntity
            where TTarget : BaseEntity
    {

        /// <summary>
        /// 获取指定节点往上第N级的节点，如果不存在则返回NULL
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <param name="depth">深度/距离 0：返回自身的DtId，1：返回父级DtId,以此类推</param>
        /// <returns>上级节点的DtId</returns>
        public async Task<Guid?> GetSourceDtId(Guid currentNodeDtId, int depth)
        {
            return await this.Where(m => m.TargetId == currentNodeDtId && m.Depth == depth)
               .Select(m => m.SourceId)
               .FirstOrDefaultAsync();
        }
        /// <summary>
        /// 获取指定节点是那一级的，根级别是0
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <returns>级别</returns>
        public async Task<int?> GetLevel(Guid currentNodeDtId)
        {
            return await this.GetDepth(currentNodeDtId, null);
        }
        /// <summary>
        /// 查询指定节点到它某个祖先节点的距离
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <param name="parentDtId"></param>
        /// <returns>距离，如果 parentDtId 并不是其祖先节点则返回 null</returns>
        public async Task<int?> GetDepth(Guid currentNodeDtId, Guid? parentDtId)
        {
            // 获取当前节点到指定父节点的距离
            var distance = await this.Where(m => m.TargetId == currentNodeDtId && m.SourceId == parentDtId)
                .Select(m => m)
                .FirstOrDefaultAsync();
            return distance?.Depth;
        }
        /// <summary>
        /// 获取指定节点往下的第N级节点列表
        /// </summary>
        /// <param name="currentDtId"></param>
        /// <param name="depth">往下级数 0：自己、1：子节点；2、子节点的子节点，以此类推</param>
        /// <returns></returns>
        public async Task<List<TTarget>> GetSubLayer(Guid currentDtId, int depth)
        {
            return await this.Where(m => m.SourceId == currentDtId && m.Depth == depth)
                .Select(m => m.Target)
                .ToListAsync();
        }
        /// <summary>
        /// 获取直接下级列表
        /// </summary>
        /// <param name="currentNodeDtId">要获取谁的直接下级列表</param>
        /// <returns></returns>
        public async Task<List<TTarget>> GetChildren(Guid currentNodeDtId)
        {
            return await this.GetSubLayer(currentNodeDtId, 1);
        }

        /// <summary>
        /// 获取所有下级列表（包括直接下级和间接下级）
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <returns>返回结果顺序不做保证</returns>
        public async Task<List<TTarget>> GetTree(Guid currentNodeDtId)
        {
            return await this.Where(m => m.SourceId == currentNodeDtId)
                .Select(m => m.Target)
                .ToListAsync();
        }
        /// <summary>
        /// 获取根节点到此节点（含）路径上的所有的节点对象。
        /// </summary>
        /// <param name="parentDtId"></param>
        /// <returns>节点列表，越上级的节点在列表中的位置越靠前</returns>
        public async Task<List<TSource>> GetPath(Guid currentDtId)
        {
            return await this.Where(m => m.TargetId == currentDtId && m.SourceId != null)
                .OrderByDescending(m => m.Depth)
                .Select(m => m.Source)
                .ToListAsync();
        }
        /// <summary>
        /// 获取指定分类（含）到其某个的上级分类（不含）之间的所有分类的对象。
        /// 如果上级分类不存在，或是上级分类不是指定分类的上级，则返回空列表
        /// </summary>
        /// <param name="parentDtId">上级节点</param>
        /// <returns>节点列表，越靠上的节点在列表中的位置越靠前</returns>
        public async Task<List<TSource>> GetPath(Guid currentDtId, Guid parentDtId)
        {
            return await this.Where(m => m.TargetId == currentDtId
            && m.Depth < (this.Where(d => d.TargetId == currentDtId
                && d.SourceId == parentDtId)
                .Select(d => d.Depth).First()))
                .Select(m => m.Source)
                .ToListAsync();
        }
        /// <summary>
        /// 将一个分类移动到目标分类下面（成为其子分类）。被移动分类的子类将自动上浮
        /// （成为指定分类父类的子分类），即使目标是指定分类原本的父类。
        /// <para>
        /// 例如下图（省略根分类）：
        /// </para>
        /// <code>
        ///       1                                    1
        ///       |                                  / | \
        ///       2                                 3  4  5
        ///     / | \         (id=2).moveTo(7)           / \
        ///    3  4  5       ----------------->         6   7
        ///         / \                                /  / | \
        ///       6    7                              8  9  10 2
        ///      /    /  \
        ///     8    9    10
        /// </code>
        /// </summary>
        /// <param name="newParent">目标分类的id</param>
        /// <exception cref="ArgumentException">如果 target 所表示的分类不存在或是自身</exception>

        public async Task MoveTo(Guid? currentDtId, Guid? newParentDtId)
        {
            if (currentDtId == null)
            {
                throw new Exception
                    ("根分类不支持此操作");
            }
            if (currentDtId == newParentDtId)
            {
                throw new Exception("不能移动到自己下面");
            }

            await this.MoveSubTree(currentDtId.Value, await this.GetSourceDtId(currentDtId.Value, 1));
            await this.MoveNode(currentDtId.Value, newParentDtId);
        }
        /// <summary>
        /// 将一个分类移动到目标分类下面（成为其子分类），被移动分类的子分类也会随着移动。
        /// 如果目标分类是被移动分类的子类，则先将目标分类（连带子类）移动到被移动分类原来的
        /// 位置，再移动需要被移动的分类。
        /// <para>
        /// 例如下图（省略根分类）：
        /// </para>
        /// <code>
        ///       1                                      1
        ///       |                                      |
        ///       2                                      7
        ///     / | \        (id=2).moveTreeTo(7)      / | \
        ///    3  4  5      -------------------->     9  10  2
        ///         / \                                  / | \
        ///       6    7                                3  4  5
        ///      /    /  \                                    |
        ///     8    9    10                                  6
        ///                                                    |
        ///                                                    8
        /// </code>
        /// </summary>
        /// <param name="newParent">目标分类的</param>
        /// <exception cref="ArgumentException">如果 target 所表示的分类不存在或是自身</exception>

        public async Task MoveTreeTo(Guid? currentDtId, Guid? newParentDtId)
        {
            if (currentDtId == null)
            {
                throw new Exception("根分类不支持此操作");
            }

            // 移动分移到自己子树下和无关节点下两种情况
            var distance = await this.GetDepth(newParentDtId == null ? Guid.Empty : newParentDtId.Value, currentDtId);

            if (distance == null)
            {
                // 移动到父节点或其他无关系节点，不需要做额外动作
            }
            else if (distance == 0)
            {
                throw new Exception("不能移动到自己下面");
            }
            else
            {
                // 如果移动的目标是其子类，需要先把子类移动到本类的位置
                Guid? parent = await this.GetSourceDtId(currentDtId.Value, 1);
                await this.MoveNode(newParentDtId.Value, parent);
                await this.MoveSubTree(newParentDtId.Value, newParentDtId);
            }

            await this.MoveNode(currentDtId.Value, newParentDtId);
            await this.MoveSubTree(currentDtId.Value, currentDtId);
        }





        /// <summary>
        /// 将指定节点移动到某节点下面，该方法不修改子节点的相关记录，
        /// 为了保证数据的完整性，需要与 moveSubTree() 方法配合使用。
        /// </summary>
        /// <param name="id">指定节点的 ID</param>
        /// <param name="parent">新的父节点 ID</param>
        public async Task MoveNode(Guid currentDtId, Guid? parentDtId)
        {
            await this.DeletePath(currentDtId);
            if (parentDtId != null)
                await this.InsertPath(currentDtId, parentDtId.Value);
            await this.InsertSelfLink(currentDtId);
        }
        public async Task InsertSelfLink(Guid currentDtId)
        {
            // Replace the instantiation of T with a factory method or delegate to create the instance
            var relationship = new T
            {
                SourceId = currentDtId,
                TargetId = currentDtId,
                Depth = 0
            };
            await this.AddAsync(relationship);
        }
        public async Task InsertPath(Guid currenDtId, Guid parentDtId)
        {
            var sources = await this.Where(m => m.TargetId == parentDtId)
                .Select(m => new
                {
                    SourceId = m.SourceId,
                    TargetId = currenDtId,
                    Depth = m.Depth + 1
                })
                .ToListAsync();

            if (sources.Count > 0)
            {

                var relationships = sources.Select(s =>
                {
                    var relationship = new T();
                    relationship.SourceId = s.SourceId;
                    relationship.TargetId = s.TargetId;
                    relationship.Depth = s.Depth;
                    return relationship;
                }).ToList();
                await this.AddRangeAsync(relationships);

            }
        }

        public async Task<int> DeletePath(Guid currentDtId)
        {
            return await this.Where(m => m.TargetId == currentDtId)
                  .ExecuteUpdateAsync(m => m.SetProperty(p => p.IsDelete, true));
        }

        /// <summary>
        /// 将指定节点的所有子树移动到某节点下
        /// 如果两个参数相同，则相当于重建子树，用于父节点移动后更新路径
        /// </summary>
        /// <param name="id">指定节点的 ID</param>
        /// <param name="parent">新的父节点 ID</param>
        public async Task MoveSubTree(Guid currenDtId, Guid? parentDtId)
        {
            var subs = await this.SelectSubId(currenDtId);
            foreach (Guid sub in subs)
            {
                await this.MoveNode(sub, parentDtId);
                await this.MoveSubTree(sub, sub);
            }
        }

        public async Task<List<Guid>> SelectSubId(Guid? parentDtId)
        {
            return await this.Where(m => m.SourceId == parentDtId && m.Depth == 1)
                .Select(m => m.TargetId)
                .ToListAsync();
        }
    }
}