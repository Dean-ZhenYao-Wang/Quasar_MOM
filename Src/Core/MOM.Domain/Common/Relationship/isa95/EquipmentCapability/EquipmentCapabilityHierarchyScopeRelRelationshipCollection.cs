namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}