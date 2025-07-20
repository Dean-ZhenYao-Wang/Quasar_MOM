using MOM.Domain.Common;
using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IRelationshipRepository<T, TSource, TTarget> : IGenericRepository<T>
         where T : Relationship<TSource, TTarget>
        where TSource : BaseEntity
        where TTarget : BaseEntity
    {
        Task AddAsync(Guid currentDtId, Guid? parentDtId);

        Task<int> DeletePath(Guid currentDtId);

        Task<int> DeletePath(IEnumerable<Guid> currentDtIds);

        Task<List<TTarget>> GetChildren(Guid currentNodeDtId);

        Task<int?> GetDepth(Guid currentNodeDtId, Guid? parentDtId);

        Task<int?> GetLevel(Guid currentNodeDtId);

        Task<string> GetPathAsync(Guid currentDtId);

        Task<string> GetPath(Guid currentDtId, Guid parentDtId);

        Task<Guid?> GetSourceDtId(Guid currentNodeDtId, int depth);

        Task<List<TTarget>> GetSubLayer(Guid currentDtId, int depth);

        Task<List<TTarget>> GetTree(Guid currentNodeDtId);

        Task InsertPath(Guid currenDtId, Guid parentDtId);

        Task InsertSelfLink(Guid currentDtId);

        Task MoveNode(Guid currentDtId, Guid? parentDtId);

        Task MoveSubTree(Guid currenDtId, Guid? parentDtId);

        Task MoveTo(Guid? currentDtId, Guid? newParentDtId);

        Task MoveTreeTo(Guid? currentDtId, Guid? newParentDtId);

        Task<List<Guid>> SelectSubId(Guid? parentDtId);
    }
    public interface IHierarchyScopeRelationshipRepository<T, TSource, TTarget> : IGenericRepository<T>
        where T : HierarchyScopeRelationship<TSource, TTarget>
       where TSource : class
       where TTarget : HierarchyScope
    {
        Task AddAsync(Guid currentDtId, Guid? parentDtId, string? name = null);
        Task<int> DeletePathAsync(Guid currentDtId);
        Task<int> DeletePathAsync(IEnumerable<Guid> currentDtIds);
        /// <summary>
        /// 获取直接下级列表
        /// </summary>
        /// <param name="currentNodeDtId">要获取谁的直接下级列表</param>
        /// <returns></returns>
        Task<List<TTarget>> GetChildrenAsync(Guid currentNodeDtId);
        /// <summary>
        /// 查询指定节点到它某个祖先节点的距离
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <param name="parentDtId"></param>
        /// <returns>距离，如果 parentDtId 并不是其祖先节点则返回 null</returns>
        Task<int?> GetDepthAsync(Guid currentNodeDtId, Guid? parentDtId);
        /// <summary>
        /// 获取指定节点是那一级的，根级别是0
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <returns>级别</returns>
        Task<int?> GetLevelAsync(Guid currentNodeDtId);
        /// <summary>
        /// 获取指定分类（含）到其某个的上级分类（不含）之间的所有分类的对象。
        /// 如果上级分类不存在，或是上级分类不是指定分类的上级，则返回空列表
        /// </summary>
        /// <param name="parentDtId">上级节点</param>
        /// <returns>节点列表，越靠上的节点在列表中的位置越靠前</returns>
        Task<string> GetPathAsync(Guid currentDtId, Guid parentDtId);

        /// <summary>
        /// 获取根节点到此节点（含）路径上的所有的节点名称。
        /// </summary>
        /// <param name="parentDtId"></param>
        /// <returns>节点列表，越上级的节点在列表中的位置越靠前</returns>
        Task<string> GetPathAsync(Guid currentDtId);
        /// <summary>
        /// 获取指定节点往上第N级的节点，如果不存在则返回NULL
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <param name="depth">深度/距离 0：返回自身的DtId，1：返回父级DtId,以此类推</param>
        /// <returns>上级节点的DtId</returns>
        Task<Guid?> GetSourceDtIdAsync(Guid currentNodeDtId, int depth);
        /// <summary>
        /// 获取指定节点往下的第N级节点列表
        /// </summary>
        /// <param name="currentDtId"></param>
        /// <param name="depth">往下级数 0：自己、1：子节点；2、子节点的子节点，以此类推</param>
        /// <returns></returns>
        Task<List<TTarget>> GetSubLayerAsync(Guid currentDtId, int depth);
        /// <summary>
        /// 获取所有下级列表（包括直接下级和间接下级）
        /// </summary>
        /// <param name="currentNodeDtId"></param>
        /// <returns>返回结果顺序不做保证</returns>
        Task<List<TTarget>> GetTreeAsync(Guid currentNodeDtId);
        Task InsertPathAsync(Guid currenDtId, Guid parentDtId, string? name = null);
        Task InsertSelfLinkAsync(Guid currentDtId, string? name = null);
        /// <summary>
        /// 将指定节点移动到某节点下面，该方法不修改子节点的相关记录，
        /// 为了保证数据的完整性，需要与 moveSubTree() 方法配合使用。
        /// </summary>
        /// <param name="id">指定节点的 ID</param>
        /// <param name="parent">新的父节点 ID</param>
        Task MoveNodeAsync(Guid currentDtId, Guid? parentDtId, string? name = null);
        /// <summary>
        /// 将指定节点的所有子树移动到某节点下
        /// 如果两个参数相同，则相当于重建子树，用于父节点移动后更新路径
        /// </summary>
        /// <param name="id">指定节点的 ID</param>
        /// <param name="parent">新的父节点 ID</param>
        Task MoveSubTreeAsync(Guid currenDtId, Guid? parentDtId, string? name = null);
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
        Task MoveToAsync(Guid? currentDtId, Guid? newParentDtId, string? name = null);
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
        Task MoveTreeToAsync(Guid? currentDtId, Guid? newParentDtId, string? name = null);
        Task<List<Guid>> SelectSubIdAsync(Guid? parentDtId);
    }
}