namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentHierarchyScopeRelRelationship>())
        {
        }
    }
}