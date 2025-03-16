namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionIncludesPropertiesOfRelationshipCollection : RelationshipCollection<OperationsDefinitionIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public OperationsDefinitionIncludesPropertiesOfRelationshipCollection(IEnumerable<OperationsDefinitionIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsDefinitionIncludesPropertiesOfRelationship>())
        {
        }
    }
}