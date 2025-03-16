namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToAProcessSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<SegmentResponseCorrespondsToAProcessSegmentRelationship>
    {
        public SegmentResponseCorrespondsToAProcessSegmentRelationship()
        {
            Name = "correspondsToAProcessSegment";
        }

        public SegmentResponseCorrespondsToAProcessSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseCorrespondsToAProcessSegmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseCorrespondsToAProcessSegmentRelationship);
        }

        public bool Equals(SegmentResponseCorrespondsToAProcessSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseCorrespondsToAProcessSegmentRelationship? left, SegmentResponseCorrespondsToAProcessSegmentRelationship? right)
        {
            return EqualityComparer<SegmentResponseCorrespondsToAProcessSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseCorrespondsToAProcessSegmentRelationship? left, SegmentResponseCorrespondsToAProcessSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseCorrespondsToAProcessSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}