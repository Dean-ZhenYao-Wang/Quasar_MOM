namespace MOM.Domain.Common.Relationship.isa95.WorkDirective
{
    public class WorkDirectiveHasARelationshipCollection : RelationshipCollection<WorkDirectiveHasARelationship, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>
    {
        public WorkDirectiveHasARelationshipCollection(IEnumerable<WorkDirectiveHasARelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDirectiveHasARelationship>())
        {
        }
    }
}