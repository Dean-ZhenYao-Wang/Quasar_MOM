namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationProperty
{
    public class OperationalLocationPropertyMapsToRelationshipCollection : RelationshipCollection<OperationalLocationPropertyMapsToRelationship, MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty>
    {
        public OperationalLocationPropertyMapsToRelationshipCollection(IEnumerable<OperationalLocationPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationPropertyMapsToRelationship>())
        {
        }
    }
}