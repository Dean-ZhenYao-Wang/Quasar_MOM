namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassIsAssembledFromRelationshipCollection : RelationshipCollection<OperationsEventClassIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass>
    {
        public OperationsEventClassIsAssembledFromRelationshipCollection(IEnumerable<OperationsEventClassIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventClassIsAssembledFromRelationship>())
        {
        }
    }
}