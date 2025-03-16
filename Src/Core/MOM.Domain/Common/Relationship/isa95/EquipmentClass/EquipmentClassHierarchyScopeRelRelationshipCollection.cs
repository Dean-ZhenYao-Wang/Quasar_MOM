namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    public class EquipmentClassHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentClassHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentClassHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentClassHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentClassHierarchyScopeRelRelationship>())
        {
        }
    }
}