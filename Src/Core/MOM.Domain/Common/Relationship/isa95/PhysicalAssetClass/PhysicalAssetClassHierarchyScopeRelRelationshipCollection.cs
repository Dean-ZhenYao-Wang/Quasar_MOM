namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetClassHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetClassHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetClassHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetClassHierarchyScopeRelRelationship>())
        {
        }
    }
}