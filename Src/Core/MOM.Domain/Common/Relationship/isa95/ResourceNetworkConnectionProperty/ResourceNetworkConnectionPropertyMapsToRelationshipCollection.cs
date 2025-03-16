namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionProperty
{
    public class ResourceNetworkConnectionPropertyMapsToRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty>
    {
        public ResourceNetworkConnectionPropertyMapsToRelationshipCollection(IEnumerable<ResourceNetworkConnectionPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionPropertyMapsToRelationship>())
        {
        }
    }
}