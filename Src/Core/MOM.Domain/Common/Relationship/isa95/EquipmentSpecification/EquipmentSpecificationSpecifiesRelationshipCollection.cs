namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecification
{
    public class EquipmentSpecificationSpecifiesRelationshipCollection : RelationshipCollection<EquipmentSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public EquipmentSpecificationSpecifiesRelationshipCollection(IEnumerable<EquipmentSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSpecificationSpecifiesRelationship>())
        {
        }
    }
}