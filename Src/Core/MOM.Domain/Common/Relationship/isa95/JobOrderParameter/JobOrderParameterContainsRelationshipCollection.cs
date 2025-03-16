namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterContainsRelationshipCollection : RelationshipCollection<JobOrderParameterContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrderParameter>
    {
        public JobOrderParameterContainsRelationshipCollection(IEnumerable<JobOrderParameterContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderParameterContainsRelationship>())
        {
        }
    }
}