namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionIsAssembledFromRelationshipCollection : RelationshipCollection<OperationsEventDefinitionIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition>
    {
        public OperationsEventDefinitionIsAssembledFromRelationshipCollection(IEnumerable<OperationsEventDefinitionIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionIsAssembledFromRelationship>())
        {
        }
    }
}