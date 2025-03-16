namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualOperationalLocationRelRelationshipCollection : RelationshipCollection<EquipmentActualOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public EquipmentActualOperationalLocationRelRelationshipCollection(IEnumerable<EquipmentActualOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualOperationalLocationRelRelationship>())
        {
        }
    }
}