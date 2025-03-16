namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionContainsRelationshipCollection : RelationshipCollection<OperationsDefinitionContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsDefinitionContainsRelationshipCollection(IEnumerable<OperationsDefinitionContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsDefinitionContainsRelationship>())
        {
        }
    }
}