namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassIncludesPropertiesOfRelationshipCollection : RelationshipCollection<OperationsEventClassIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass>
    {
        public OperationsEventClassIncludesPropertiesOfRelationshipCollection(IEnumerable<OperationsEventClassIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventClassIncludesPropertiesOfRelationship>())
        {
        }
    }
}