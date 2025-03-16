namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClassProperty
{
    public class OperationalLocationClassPropertyContainsRelationshipCollection : RelationshipCollection<OperationalLocationClassPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty>
    {
        public OperationalLocationClassPropertyContainsRelationshipCollection(IEnumerable<OperationalLocationClassPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationClassPropertyContainsRelationship>())
        {
        }
    }
}