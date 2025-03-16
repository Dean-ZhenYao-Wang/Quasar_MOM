namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsParameterRelationshipCollection : RelationshipCollection<JobOrderContainsParameterRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter>
    {
        public JobOrderContainsParameterRelationshipCollection(IEnumerable<JobOrderContainsParameterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderContainsParameterRelationship>())
        {
        }
    }
}