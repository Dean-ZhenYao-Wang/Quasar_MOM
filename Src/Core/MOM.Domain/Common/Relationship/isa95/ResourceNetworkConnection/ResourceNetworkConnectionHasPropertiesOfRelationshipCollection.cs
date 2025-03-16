namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionHasPropertiesOfRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty>
    {
        public ResourceNetworkConnectionHasPropertiesOfRelationshipCollection(IEnumerable<ResourceNetworkConnectionHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionHasPropertiesOfRelationship>())
        {
        }
    }
}