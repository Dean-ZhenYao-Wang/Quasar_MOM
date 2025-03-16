namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterCorrespondsToProcessRelationshipCollection : RelationshipCollection<JobOrderParameterCorrespondsToProcessRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>
    {
        public JobOrderParameterCorrespondsToProcessRelationshipCollection(IEnumerable<JobOrderParameterCorrespondsToProcessRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderParameterCorrespondsToProcessRelationship>())
        {
        }
    }
}