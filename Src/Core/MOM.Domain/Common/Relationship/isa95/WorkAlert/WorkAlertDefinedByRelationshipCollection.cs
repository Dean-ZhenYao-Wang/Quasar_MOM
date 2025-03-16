namespace MOM.Domain.Common.Relationship.isa95.WorkAlert
{
    public class WorkAlertDefinedByRelationshipCollection : RelationshipCollection<WorkAlertDefinedByRelationship, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinition>
    {
        public WorkAlertDefinedByRelationshipCollection(IEnumerable<WorkAlertDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertDefinedByRelationship>())
        {
        }
    }
}