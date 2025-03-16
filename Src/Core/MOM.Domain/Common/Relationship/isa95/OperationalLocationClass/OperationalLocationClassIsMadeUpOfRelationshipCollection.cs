namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassIsMadeUpOfRelationshipCollection : RelationshipCollection<OperationalLocationClassIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>
    {
        public OperationalLocationClassIsMadeUpOfRelationshipCollection(IEnumerable<OperationalLocationClassIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationClassIsMadeUpOfRelationship>())
        {
        }
    }
}