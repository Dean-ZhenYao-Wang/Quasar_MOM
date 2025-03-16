namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseCorrespondsToSpecificationRelationshipCollection : RelationshipCollection<JobResponseCorrespondsToSpecificationRelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>
    {
        public JobResponseCorrespondsToSpecificationRelationshipCollection(IEnumerable<JobResponseCorrespondsToSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseCorrespondsToSpecificationRelationship>())
        {
        }
    }
}