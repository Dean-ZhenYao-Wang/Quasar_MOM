namespace MOM.Domain.Common.Relationship.isa95.WorkAlertProperty
{
    public class WorkAlertPropertyMapsToRelationshipCollection : RelationshipCollection<WorkAlertPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty>
    {
        public WorkAlertPropertyMapsToRelationshipCollection(IEnumerable<WorkAlertPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertPropertyMapsToRelationship>())
        {
        }
    }
}