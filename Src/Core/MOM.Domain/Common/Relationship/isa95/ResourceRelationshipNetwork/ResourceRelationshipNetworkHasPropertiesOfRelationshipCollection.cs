namespace MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetwork
{
    public class ResourceRelationshipNetworkHasPropertiesOfRelationshipCollection : RelationshipCollection<ResourceRelationshipNetworkHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty>
    {
        public ResourceRelationshipNetworkHasPropertiesOfRelationshipCollection(IEnumerable<ResourceRelationshipNetworkHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceRelationshipNetworkHasPropertiesOfRelationship>())
        {
        }
    }
}