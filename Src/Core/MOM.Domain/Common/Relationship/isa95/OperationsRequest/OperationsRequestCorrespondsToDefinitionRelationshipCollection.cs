namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<OperationsRequestCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public OperationsRequestCorrespondsToDefinitionRelationshipCollection(IEnumerable<OperationsRequestCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRequestCorrespondsToDefinitionRelationship>())
        {
        }
    }
}