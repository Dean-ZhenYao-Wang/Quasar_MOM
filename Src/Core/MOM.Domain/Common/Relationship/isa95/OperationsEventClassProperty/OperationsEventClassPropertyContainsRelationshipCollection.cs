namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClassProperty
{
    public class OperationsEventClassPropertyContainsRelationshipCollection : RelationshipCollection<OperationsEventClassPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty>
    {
        public OperationsEventClassPropertyContainsRelationshipCollection(IEnumerable<OperationsEventClassPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventClassPropertyContainsRelationship>())
        {
        }
    }
}