namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityCorrespondsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsSegmentCapabilityCorrespondsToRelationship>
    {
        public OperationsSegmentCapabilityCorrespondsToRelationship()
        {
            Name = "correspondsTo";
        }

        public OperationsSegmentCapabilityCorrespondsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentCapabilityCorrespondsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapabilityCorrespondsToRelationship);
        }

        public bool Equals(OperationsSegmentCapabilityCorrespondsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentCapabilityCorrespondsToRelationship? left, OperationsSegmentCapabilityCorrespondsToRelationship? right)
        {
            return EqualityComparer<OperationsSegmentCapabilityCorrespondsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapabilityCorrespondsToRelationship? left, OperationsSegmentCapabilityCorrespondsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentCapabilityCorrespondsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}