namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationSpecifiesTestForObjectRelationshipCollection : RelationshipCollection<TestSpecificationSpecifiesTestForObjectRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject>
    {
        public TestSpecificationSpecifiesTestForObjectRelationshipCollection(IEnumerable<TestSpecificationSpecifiesTestForObjectRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationSpecifiesTestForObjectRelationship>())
        {
        }
    }
}