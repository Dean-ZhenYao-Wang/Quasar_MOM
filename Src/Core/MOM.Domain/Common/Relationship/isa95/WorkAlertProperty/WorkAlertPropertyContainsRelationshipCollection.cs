namespace MOM.Domain.Common.Relationship.isa95.WorkAlertProperty
{
    public class WorkAlertPropertyContainsRelationshipCollection : RelationshipCollection<WorkAlertPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertProperty>
    {
        public WorkAlertPropertyContainsRelationshipCollection(IEnumerable<WorkAlertPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertPropertyContainsRelationship>())
        {
        }
    }
}