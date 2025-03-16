namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty>, IEquatable<ResourceNetworkConnectionHasPropertiesOfRelationship>
    {
        public ResourceNetworkConnectionHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public ResourceNetworkConnectionHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionHasPropertiesOfRelationship);
        }

        public bool Equals(ResourceNetworkConnectionHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionHasPropertiesOfRelationship? left, ResourceNetworkConnectionHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionHasPropertiesOfRelationship? left, ResourceNetworkConnectionHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}