namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementHierarchyScopeRelRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PhysicalAssetRequirementHierarchyScopeRelRelationshipCollection(IEnumerable<PhysicalAssetRequirementHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementHierarchyScopeRelRelationship>())
        {
        }
    }
}