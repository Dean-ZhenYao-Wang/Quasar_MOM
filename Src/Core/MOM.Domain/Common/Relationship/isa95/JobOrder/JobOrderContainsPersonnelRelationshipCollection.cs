namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsPersonnelRelationshipCollection : RelationshipCollection<JobOrderContainsPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement>
    {
        public JobOrderContainsPersonnelRelationshipCollection(IEnumerable<JobOrderContainsPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderContainsPersonnelRelationship>())
        {
        }
    }
}