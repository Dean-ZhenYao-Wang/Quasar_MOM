namespace MOM.Domain.Common.Relationship.isa95.TestSpecificationProperty
{
    public class TestSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<TestSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationProperty>
    {
        public TestSpecificationPropertyContainsRelationshipCollection(IEnumerable<TestSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationPropertyContainsRelationship>())
        {
        }
    }
}