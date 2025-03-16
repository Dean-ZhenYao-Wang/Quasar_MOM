namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}