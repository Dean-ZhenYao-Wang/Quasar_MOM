namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassHasPropertiesOfRelationshipCollection : RelationshipCollection<OperationsEventClassHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty>
    {
        public OperationsEventClassHasPropertiesOfRelationshipCollection(IEnumerable<OperationsEventClassHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventClassHasPropertiesOfRelationship>())
        {
        }
    }
}