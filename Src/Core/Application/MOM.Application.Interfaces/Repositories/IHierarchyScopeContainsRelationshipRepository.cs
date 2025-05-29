using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IHierarchyScopeContainsRelationshipRepository : IRelationshipRepository<HierarchyScopeContainsRelationship,HierarchyScope,HierarchyScope>
    {
    }
}