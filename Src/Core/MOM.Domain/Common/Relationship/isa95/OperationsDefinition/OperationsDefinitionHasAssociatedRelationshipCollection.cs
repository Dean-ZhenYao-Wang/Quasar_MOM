namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionHasAssociatedRelationshipCollection : RelationshipCollection<OperationsDefinitionHasAssociatedRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBill>
    {
        public OperationsDefinitionHasAssociatedRelationshipCollection(IEnumerable<OperationsDefinitionHasAssociatedRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsDefinitionHasAssociatedRelationship>())
        {
        }
    }
}