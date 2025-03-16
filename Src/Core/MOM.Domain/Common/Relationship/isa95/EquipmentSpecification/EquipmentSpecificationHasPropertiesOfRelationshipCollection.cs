namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<EquipmentSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecificationProperty>
    {
        public EquipmentSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<EquipmentSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}