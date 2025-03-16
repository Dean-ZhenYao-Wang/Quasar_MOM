namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationSpecifiesTestForOperationsRelationshipCollection : RelationshipCollection<TestSpecificationSpecifiesTestForOperationsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.OperationsTestRequirement>
    {
        public TestSpecificationSpecifiesTestForOperationsRelationshipCollection(IEnumerable<TestSpecificationSpecifiesTestForOperationsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationSpecifiesTestForOperationsRelationship>())
        {
        }
    }
}