namespace MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetworkProperty
{
    public class ResourceRelationshipNetworkPropertyContainsRelationshipCollection : RelationshipCollection<ResourceRelationshipNetworkPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty>
    {
        public ResourceRelationshipNetworkPropertyContainsRelationshipCollection(IEnumerable<ResourceRelationshipNetworkPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceRelationshipNetworkPropertyContainsRelationship>())
        {
        }
    }
}