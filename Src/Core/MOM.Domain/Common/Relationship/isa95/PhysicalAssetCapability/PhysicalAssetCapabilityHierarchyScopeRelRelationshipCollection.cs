namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}