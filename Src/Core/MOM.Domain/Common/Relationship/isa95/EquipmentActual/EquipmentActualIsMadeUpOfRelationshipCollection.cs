namespace MOM.Domain.Common.Relationship.isa95.EquipmentActual
{
    public class EquipmentActualIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentActualIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual>
    {
        public EquipmentActualIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentActualIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentActualIsMadeUpOfRelationship>())
        {
        }
    }
}