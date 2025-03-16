namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualHasValuesOfRelationshipCollection : RelationshipCollection<EquipmentActualHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty>
    {
        public EquipmentActualHasValuesOfRelationshipCollection(IEnumerable<EquipmentActualHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualHasValuesOfRelationship>())
        {
        }
    }
}