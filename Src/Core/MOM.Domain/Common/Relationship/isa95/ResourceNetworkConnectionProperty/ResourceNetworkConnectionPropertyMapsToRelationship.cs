namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionProperty
{
    public class ResourceNetworkConnectionPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty>, IEquatable<ResourceNetworkConnectionPropertyMapsToRelationship>
    {
        public ResourceNetworkConnectionPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public ResourceNetworkConnectionPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionPropertyMapsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionPropertyMapsToRelationship);
        }

        public bool Equals(ResourceNetworkConnectionPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionPropertyMapsToRelationship? left, ResourceNetworkConnectionPropertyMapsToRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionPropertyMapsToRelationship? left, ResourceNetworkConnectionPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}