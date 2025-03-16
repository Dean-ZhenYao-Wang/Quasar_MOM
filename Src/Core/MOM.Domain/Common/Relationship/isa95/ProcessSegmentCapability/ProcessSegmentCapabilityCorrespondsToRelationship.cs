namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityCorrespondsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<ProcessSegmentCapabilityCorrespondsToRelationship>
    {
        public ProcessSegmentCapabilityCorrespondsToRelationship()
        {
            Name = "correspondsTo";
        }

        public ProcessSegmentCapabilityCorrespondsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityCorrespondsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityCorrespondsToRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityCorrespondsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityCorrespondsToRelationship? left, ProcessSegmentCapabilityCorrespondsToRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityCorrespondsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityCorrespondsToRelationship? left, ProcessSegmentCapabilityCorrespondsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityCorrespondsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}