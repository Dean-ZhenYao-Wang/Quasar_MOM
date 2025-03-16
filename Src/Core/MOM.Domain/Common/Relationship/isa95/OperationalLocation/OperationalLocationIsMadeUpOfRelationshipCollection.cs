namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationIsMadeUpOfRelationshipCollection : RelationshipCollection<OperationalLocationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public OperationalLocationIsMadeUpOfRelationshipCollection(IEnumerable<OperationalLocationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationIsMadeUpOfRelationship>())
        {
        }
    }
}