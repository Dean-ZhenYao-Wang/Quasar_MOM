
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
        Task<List<TSource>> GetPath(Guid currentDtId);
        Task<List<TSource>> GetPath(Guid currentDtId, Guid parentDtId);
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
}