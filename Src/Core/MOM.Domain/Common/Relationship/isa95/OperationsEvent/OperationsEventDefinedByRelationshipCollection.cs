namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventDefinedByRelationshipCollection : RelationshipCollection<OperationsEventDefinedByRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition>
    {
        public OperationsEventDefinedByRelationshipCollection(IEnumerable<OperationsEventDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinedByRelationship>())
        {
        }
    }
}