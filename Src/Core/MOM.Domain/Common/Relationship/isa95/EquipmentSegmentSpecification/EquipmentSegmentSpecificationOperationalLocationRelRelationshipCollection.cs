namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationOperationalLocationRelRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public EquipmentSegmentSpecificationOperationalLocationRelRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationOperationalLocationRelRelationship>())
        {
        }
    }
}