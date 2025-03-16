namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionHasPropertiesOfRelationshipCollection : RelationshipCollection<OperationsEventDefinitionHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty>
    {
        public OperationsEventDefinitionHasPropertiesOfRelationshipCollection(IEnumerable<OperationsEventDefinitionHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionHasPropertiesOfRelationship>())
        {
        }
    }
}