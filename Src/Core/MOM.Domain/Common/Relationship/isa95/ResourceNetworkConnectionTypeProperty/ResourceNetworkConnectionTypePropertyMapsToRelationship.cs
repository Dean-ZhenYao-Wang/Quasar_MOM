namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionTypeProperty
{
    public class ResourceNetworkConnectionTypePropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty>, IEquatable<ResourceNetworkConnectionTypePropertyMapsToRelationship>
    {
        public ResourceNetworkConnectionTypePropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public ResourceNetworkConnectionTypePropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionTypePropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionTypePropertyMapsToRelationship);
        }

        public bool Equals(ResourceNetworkConnectionTypePropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionTypePropertyMapsToRelationship? left, ResourceNetworkConnectionTypePropertyMapsToRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionTypePropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionTypePropertyMapsToRelationship? left, ResourceNetworkConnectionTypePropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionTypePropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}