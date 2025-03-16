namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventHasValuesOfRelationshipCollection : RelationshipCollection<OperationsEventHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty>
    {
        public OperationsEventHasValuesOfRelationshipCollection(IEnumerable<OperationsEventHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventHasValuesOfRelationship>())
        {
        }
    }
}