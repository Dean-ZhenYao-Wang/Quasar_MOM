namespace MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetwork
{
    public class ResourceRelationshipNetworkHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty>, IEquatable<ResourceRelationshipNetworkHasPropertiesOfRelationship>
    {
        public ResourceRelationshipNetworkHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public ResourceRelationshipNetworkHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetwork source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceRelationshipNetworkProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceRelationshipNetworkHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceRelationshipNetworkHasPropertiesOfRelationship);
        }

        public bool Equals(ResourceRelationshipNetworkHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceRelationshipNetworkHasPropertiesOfRelationship? left, ResourceRelationshipNetworkHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<ResourceRelationshipNetworkHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceRelationshipNetworkHasPropertiesOfRelationship? left, ResourceRelationshipNetworkHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceRelationshipNetworkHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}