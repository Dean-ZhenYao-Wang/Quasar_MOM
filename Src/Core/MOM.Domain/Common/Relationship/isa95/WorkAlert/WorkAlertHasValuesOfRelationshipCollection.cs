namespace MOM.Domain.Common.Relationship.isa95.WorkAlert
{
    public class WorkAlertHasValuesOfRelationshipCollection : RelationshipCollection<WorkAlertHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertProperty>
    {
        public WorkAlertHasValuesOfRelationshipCollection(IEnumerable<WorkAlertHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertHasValuesOfRelationship>())
        {
        }
    }
}