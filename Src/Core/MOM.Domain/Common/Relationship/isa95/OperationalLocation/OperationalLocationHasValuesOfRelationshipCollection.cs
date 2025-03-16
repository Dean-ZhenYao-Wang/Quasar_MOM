namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationHasValuesOfRelationshipCollection : RelationshipCollection<OperationalLocationHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty>
    {
        public OperationalLocationHasValuesOfRelationshipCollection(IEnumerable<OperationalLocationHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationHasValuesOfRelationship>())
        {
        }
    }
}