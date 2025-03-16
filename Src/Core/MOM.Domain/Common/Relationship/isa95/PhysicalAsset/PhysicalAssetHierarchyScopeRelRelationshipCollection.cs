namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetHierarchyScopeRelRelationship>())
        {
        }
    }
}