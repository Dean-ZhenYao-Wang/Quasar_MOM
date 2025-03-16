namespace MOM.Domain.Common.Relationship.isa95.WorkAlertDefinition
{
    public class WorkAlertDefinitionHasPropertiesOfRelationshipCollection : RelationshipCollection<WorkAlertDefinitionHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty>
    {
        public WorkAlertDefinitionHasPropertiesOfRelationshipCollection(IEnumerable<WorkAlertDefinitionHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertDefinitionHasPropertiesOfRelationship>())
        {
        }
    }
}