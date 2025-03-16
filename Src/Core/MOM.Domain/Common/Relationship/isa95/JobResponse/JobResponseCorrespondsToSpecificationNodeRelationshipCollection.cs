namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToSpecificationNodeRelationshipCollection : RelationshipCollection<JobResponseCorrespondsToSpecificationNodeRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode>
    {
        public JobResponseCorrespondsToSpecificationNodeRelationshipCollection(IEnumerable<JobResponseCorrespondsToSpecificationNodeRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseCorrespondsToSpecificationNodeRelationship>())
        {
        }
    }
}