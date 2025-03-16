namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionDefinedByRelationshipCollection : RelationshipCollection<ResourceNetworkConnectionDefinedByRelationship, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionType>
    {
        public ResourceNetworkConnectionDefinedByRelationshipCollection(IEnumerable<ResourceNetworkConnectionDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ResourceNetworkConnectionDefinedByRelationship>())
        {
        }
    }
}