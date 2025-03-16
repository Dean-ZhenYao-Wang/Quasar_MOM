namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<EquipmentSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification>
    {
        public EquipmentSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<EquipmentSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}