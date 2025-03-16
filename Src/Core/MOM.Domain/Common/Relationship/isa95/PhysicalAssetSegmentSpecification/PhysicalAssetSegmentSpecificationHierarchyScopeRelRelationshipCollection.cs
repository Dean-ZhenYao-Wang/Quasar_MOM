namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}