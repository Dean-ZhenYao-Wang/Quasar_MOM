namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionTypeProperty
{
    public class ResourceNetworkConnectionTypePropertyMapsToRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionTypePropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty>
    {
        public ResourceNetworkConnectionTypePropertyMapsToRelationshipCollection(IEnumerable<ResourceNetworkConnectionTypePropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionTypePropertyMapsToRelationship>())
        {
        }
    }
}