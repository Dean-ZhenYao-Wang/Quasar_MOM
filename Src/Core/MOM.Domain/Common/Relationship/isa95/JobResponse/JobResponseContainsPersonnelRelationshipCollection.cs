namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsPersonnelRelationshipCollection : RelationshipCollection<JobResponseContainsPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual>
    {
        public JobResponseContainsPersonnelRelationshipCollection(IEnumerable<JobResponseContainsPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseContainsPersonnelRelationship>())
        {
        }
    }
}