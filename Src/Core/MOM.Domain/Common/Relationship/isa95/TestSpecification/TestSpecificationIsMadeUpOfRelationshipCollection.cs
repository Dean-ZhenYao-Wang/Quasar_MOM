namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<TestSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public TestSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<TestSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}