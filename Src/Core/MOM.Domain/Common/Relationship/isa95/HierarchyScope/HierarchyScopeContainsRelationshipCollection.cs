namespace MOM.Domain.Common.Relationship.isa95.HierarchyScope
{
    public class HierarchyScopeContainsRelationshipCollection : RelationshipCollection<HierarchyScopeContainsRelationship, MOM.Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public HierarchyScopeContainsRelationshipCollection(IEnumerable<HierarchyScopeContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<HierarchyScopeContainsRelationship>())
        {
        }
    }
}