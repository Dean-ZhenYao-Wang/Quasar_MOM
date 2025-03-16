namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionProperty
{
    public class OperationsEventDefinitionPropertyMapsToRelationshipCollection : RelationshipCollection<OperationsEventDefinitionPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty>
    {
        public OperationsEventDefinitionPropertyMapsToRelationshipCollection(IEnumerable<OperationsEventDefinitionPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionPropertyMapsToRelationship>())
        {
        }
    }
}