namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentActualHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentActualHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentActualHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualHierarchyScopeRelRelationship>())
        {
        }
    }
}