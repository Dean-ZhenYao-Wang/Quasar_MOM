namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsMaterialRelationshipCollection : RelationshipCollection<JobResponseContainsMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual>
    {
        public JobResponseContainsMaterialRelationshipCollection(IEnumerable<JobResponseContainsMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseContainsMaterialRelationship>())
        {
        }
    }
}