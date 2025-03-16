namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public EquipmentSegmentSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}