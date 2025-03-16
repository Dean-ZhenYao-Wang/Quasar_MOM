namespace MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetwork
{
    public class ResourceRelationshipNetworkIsACollectionOfRelationshipCollection : RelationshipCollection<ResourceRelationshipNetworkIsACollectionOfRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection>
    {
        public ResourceRelationshipNetworkIsACollectionOfRelationshipCollection(IEnumerable<ResourceRelationshipNetworkIsACollectionOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceRelationshipNetworkIsACollectionOfRelationship>())
        {
        }
    }
}