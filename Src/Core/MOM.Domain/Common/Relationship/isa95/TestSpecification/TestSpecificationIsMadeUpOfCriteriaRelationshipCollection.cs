namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationIsMadeUpOfCriteriaRelationshipCollection : RelationshipCollection<TestSpecificationIsMadeUpOfCriteriaRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria>
    {
        public TestSpecificationIsMadeUpOfCriteriaRelationshipCollection(IEnumerable<TestSpecificationIsMadeUpOfCriteriaRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationIsMadeUpOfCriteriaRelationship>())
        {
        }
    }
}