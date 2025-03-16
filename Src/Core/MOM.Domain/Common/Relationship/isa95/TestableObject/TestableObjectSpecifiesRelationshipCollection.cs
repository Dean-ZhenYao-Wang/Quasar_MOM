namespace MOM.Domain.Common.Relationship.isa95.TestableObject
{
    public class TestableObjectSpecifiesRelationshipCollection : RelationshipCollection<TestableObjectSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public TestableObjectSpecifiesRelationshipCollection(IEnumerable<TestableObjectSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestableObjectSpecifiesRelationship>())
        {
        }
    }
}