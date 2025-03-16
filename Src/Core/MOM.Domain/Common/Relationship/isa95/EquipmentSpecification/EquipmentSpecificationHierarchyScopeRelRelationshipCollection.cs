namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}