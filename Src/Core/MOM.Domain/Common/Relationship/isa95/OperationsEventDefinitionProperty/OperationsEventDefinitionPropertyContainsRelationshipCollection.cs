namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionProperty
{
    public class OperationsEventDefinitionPropertyContainsRelationshipCollection : RelationshipCollection<OperationsEventDefinitionPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty>
    {
        public OperationsEventDefinitionPropertyContainsRelationshipCollection(IEnumerable<OperationsEventDefinitionPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionPropertyContainsRelationship>())
        {
        }
    }
}