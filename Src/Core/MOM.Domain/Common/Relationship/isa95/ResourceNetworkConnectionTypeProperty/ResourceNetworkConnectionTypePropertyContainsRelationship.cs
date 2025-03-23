namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionTypeProperty
{
    public class ResourceNetworkConnectionTypePropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty>, IEquatable<ResourceNetworkConnectionTypePropertyContainsRelationship>
    {
        public ResourceNetworkConnectionTypePropertyContainsRelationship()
        {
            Name = "contains";
        }

        public ResourceNetworkConnectionTypePropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionTypePropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionTypePropertyContainsRelationship);
        }

        public bool Equals(ResourceNetworkConnectionTypePropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionTypePropertyContainsRelationship? left, ResourceNetworkConnectionTypePropertyContainsRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionTypePropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionTypePropertyContainsRelationship? left, ResourceNetworkConnectionTypePropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionTypePropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}