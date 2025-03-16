namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<OperationsResponseCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public OperationsResponseCorrespondsToDefinitionRelationshipCollection(IEnumerable<OperationsResponseCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsResponseCorrespondsToDefinitionRelationship>())
        {
        }
    }
}