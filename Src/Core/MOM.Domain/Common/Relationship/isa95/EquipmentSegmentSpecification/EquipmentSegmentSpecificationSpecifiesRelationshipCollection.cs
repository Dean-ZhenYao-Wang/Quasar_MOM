namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationSpecifiesRelationshipCollection : RelationshipCollection<EquipmentSegmentSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public EquipmentSegmentSpecificationSpecifiesRelationshipCollection(IEnumerable<EquipmentSegmentSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentSegmentSpecificationSpecifiesRelationship>())
        {
        }
    }
}