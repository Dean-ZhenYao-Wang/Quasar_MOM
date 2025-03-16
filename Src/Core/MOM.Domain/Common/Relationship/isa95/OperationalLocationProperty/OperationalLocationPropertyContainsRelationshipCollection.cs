namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationProperty
{
    public class OperationalLocationPropertyContainsRelationshipCollection : RelationshipCollection<OperationalLocationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty>
    {
        public OperationalLocationPropertyContainsRelationshipCollection(IEnumerable<OperationalLocationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationPropertyContainsRelationship>())
        {
        }
    }
}