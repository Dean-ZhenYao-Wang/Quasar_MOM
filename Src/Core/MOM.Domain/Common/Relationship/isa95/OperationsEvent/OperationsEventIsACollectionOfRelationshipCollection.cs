namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventIsACollectionOfRelationshipCollection : RelationshipCollection<OperationsEventIsACollectionOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord>
    {
        public OperationsEventIsACollectionOfRelationshipCollection(IEnumerable<OperationsEventIsACollectionOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventIsACollectionOfRelationship>())
        {
        }
    }
}