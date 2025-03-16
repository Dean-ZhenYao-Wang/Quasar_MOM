namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationEvaluatesRelationshipCollection : RelationshipCollection<TestSpecificationEvaluatesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty>
    {
        public TestSpecificationEvaluatesRelationshipCollection(IEnumerable<TestSpecificationEvaluatesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationEvaluatesRelationship>())
        {
        }
    }
}