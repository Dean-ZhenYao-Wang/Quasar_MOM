namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionConnectsFromRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionConnectsFromRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReference>
    {
        public ResourceNetworkConnectionConnectsFromRelationshipCollection(IEnumerable<ResourceNetworkConnectionConnectsFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionConnectsFromRelationship>())
        {
        }
    }
}