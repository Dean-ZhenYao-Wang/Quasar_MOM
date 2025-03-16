namespace MOM.Domain.Common.Relationship.isa95.OperationsEventProperty
{
    public class OperationsEventPropertyContainsRelationshipCollection : RelationshipCollection<OperationsEventPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty>
    {
        public OperationsEventPropertyContainsRelationshipCollection(IEnumerable<OperationsEventPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventPropertyContainsRelationship>())
        {
        }
    }
}