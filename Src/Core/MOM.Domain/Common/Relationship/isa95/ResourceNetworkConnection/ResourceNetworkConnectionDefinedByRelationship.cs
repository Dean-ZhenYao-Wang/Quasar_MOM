namespace MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection
{
    public class ResourceNetworkConnectionDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionType>, IEquatable<ResourceNetworkConnectionDefinedByRelationship>
    {
        public ResourceNetworkConnectionDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public ResourceNetworkConnectionDefinedByRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnection source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ResourceNetworkConnectionType target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceNetworkConnectionDefinedByRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionDefinedByRelationship);
        }

        public bool Equals(ResourceNetworkConnectionDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceNetworkConnectionDefinedByRelationship? left, ResourceNetworkConnectionDefinedByRelationship? right)
        {
            return EqualityComparer<ResourceNetworkConnectionDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionDefinedByRelationship? left, ResourceNetworkConnectionDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceNetworkConnectionDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}