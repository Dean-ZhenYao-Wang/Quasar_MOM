namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventIsMadeOfRelationshipCollection : RelationshipCollection<OperationsEventIsMadeOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent>
    {
        public OperationsEventIsMadeOfRelationshipCollection(IEnumerable<OperationsEventIsMadeOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventIsMadeOfRelationship>())
        {
        }
    }
}