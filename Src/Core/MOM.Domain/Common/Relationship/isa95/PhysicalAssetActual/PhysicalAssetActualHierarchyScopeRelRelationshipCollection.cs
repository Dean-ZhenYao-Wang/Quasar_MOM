namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetActualHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetActualHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetActualHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualHierarchyScopeRelRelationship>())
        {
        }
    }
}