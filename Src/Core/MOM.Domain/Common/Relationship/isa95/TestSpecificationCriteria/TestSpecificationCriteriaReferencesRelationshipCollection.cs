namespace MOM.Domain.Common.Relationship.isa95.TestSpecificationCriteria
{
    public class TestSpecificationCriteriaReferencesRelationshipCollection : RelationshipCollection<TestSpecificationCriteriaReferencesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty>
    {
        public TestSpecificationCriteriaReferencesRelationshipCollection(IEnumerable<TestSpecificationCriteriaReferencesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationCriteriaReferencesRelationship>())
        {
        }
    }
}