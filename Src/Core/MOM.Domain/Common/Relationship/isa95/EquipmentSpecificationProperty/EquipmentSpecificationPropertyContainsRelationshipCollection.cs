namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecificationProperty
{
    public class EquipmentSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<EquipmentSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecificationProperty>
    {
        public EquipmentSpecificationPropertyContainsRelationshipCollection(IEnumerable<EquipmentSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationPropertyContainsRelationship>())
        {
        }
    }
}