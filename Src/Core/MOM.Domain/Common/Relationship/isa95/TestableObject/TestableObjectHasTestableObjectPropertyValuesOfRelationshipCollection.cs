namespace MOM.Domain.Common.Relationship.isa95.TestableObject
{
    public class TestableObjectHasTestableObjectPropertyValuesOfRelationshipCollection : RelationshipCollection<TestableObjectHasTestableObjectPropertyValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>
    {
        public TestableObjectHasTestableObjectPropertyValuesOfRelationshipCollection(IEnumerable<TestableObjectHasTestableObjectPropertyValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestableObjectHasTestableObjectPropertyValuesOfRelationship>())
        {
        }
    }
}