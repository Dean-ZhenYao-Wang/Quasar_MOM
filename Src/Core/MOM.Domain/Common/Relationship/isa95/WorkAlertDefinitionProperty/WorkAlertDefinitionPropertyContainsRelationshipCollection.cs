namespace MOM.Domain.Common.Relationship.isa95.WorkAlertDefinitionProperty
{
    public class WorkAlertDefinitionPropertyContainsRelationshipCollection : RelationshipCollection<WorkAlertDefinitionPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty>
    {
        public WorkAlertDefinitionPropertyContainsRelationshipCollection(IEnumerable<WorkAlertDefinitionPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertDefinitionPropertyContainsRelationship>())
        {
        }
    }
}