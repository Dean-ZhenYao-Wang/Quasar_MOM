namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToWorkDirectiveRelationshipCollection : RelationshipCollection<JobResponseCorrespondsToWorkDirectiveRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective>
    {
        public JobResponseCorrespondsToWorkDirectiveRelationshipCollection(IEnumerable<JobResponseCorrespondsToWorkDirectiveRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseCorrespondsToWorkDirectiveRelationship>())
        {
        }
    }
}