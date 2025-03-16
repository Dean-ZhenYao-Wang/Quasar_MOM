namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirement
{
    public class EquipmentRequirementHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentRequirementHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentRequirementHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentRequirementHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentRequirementHierarchyScopeRelRelationship>())
        {
        }
    }
}