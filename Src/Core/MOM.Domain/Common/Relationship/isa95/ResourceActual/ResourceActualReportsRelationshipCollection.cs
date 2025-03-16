namespace MOM.Domain.Common.Relationship.isa95.ResourceActual
{
    public class ResourceActualReportsRelationshipCollection : RelationshipCollection<ResourceActualReportsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestResult>
    {
        public ResourceActualReportsRelationshipCollection(IEnumerable<ResourceActualReportsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceActualReportsRelationship>())
        {
        }
    }
}