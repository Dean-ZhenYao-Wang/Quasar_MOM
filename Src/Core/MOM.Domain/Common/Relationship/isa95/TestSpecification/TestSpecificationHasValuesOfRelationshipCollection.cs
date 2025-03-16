namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationHasValuesOfRelationshipCollection : RelationshipCollection<TestSpecificationHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationProperty>
    {
        public TestSpecificationHasValuesOfRelationshipCollection(IEnumerable<TestSpecificationHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationHasValuesOfRelationship>())
        {
        }
    }
}