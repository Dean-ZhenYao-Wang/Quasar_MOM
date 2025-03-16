namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionIsAMemberOfRelationshipCollection : RelationshipCollection<OperationsEventDefinitionIsAMemberOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass>
    {
        public OperationsEventDefinitionIsAMemberOfRelationshipCollection(IEnumerable<OperationsEventDefinitionIsAMemberOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionIsAMemberOfRelationship>())
        {
        }
    }
}