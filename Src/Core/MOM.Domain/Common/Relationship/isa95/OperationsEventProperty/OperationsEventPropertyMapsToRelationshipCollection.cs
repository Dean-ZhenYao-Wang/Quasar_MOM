namespace MOM.Domain.Common.Relationship.isa95.OperationsEventProperty
{
    public class OperationsEventPropertyMapsToRelationshipCollection : RelationshipCollection<OperationsEventPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty>
    {
        public OperationsEventPropertyMapsToRelationshipCollection(IEnumerable<OperationsEventPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventPropertyMapsToRelationship>())
        {
        }
    }
}