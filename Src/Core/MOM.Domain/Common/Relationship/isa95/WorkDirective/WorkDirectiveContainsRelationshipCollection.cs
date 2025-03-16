namespace MOM.Domain.Common.Relationship.isa95.WorkDirective
{
    public class WorkDirectiveContainsRelationshipCollection : RelationshipCollection<WorkDirectiveContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective>
    {
        public WorkDirectiveContainsRelationshipCollection(IEnumerable<WorkDirectiveContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDirectiveContainsRelationship>())
        {
        }
    }
}