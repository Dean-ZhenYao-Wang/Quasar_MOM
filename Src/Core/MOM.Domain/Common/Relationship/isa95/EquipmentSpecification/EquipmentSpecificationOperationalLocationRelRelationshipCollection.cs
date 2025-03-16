namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationOperationalLocationRelRelationshipCollection : RelationshipCollection<EquipmentSpecificationOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public EquipmentSpecificationOperationalLocationRelRelationshipCollection(IEnumerable<EquipmentSpecificationOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationOperationalLocationRelRelationship>())
        {
        }
    }
}