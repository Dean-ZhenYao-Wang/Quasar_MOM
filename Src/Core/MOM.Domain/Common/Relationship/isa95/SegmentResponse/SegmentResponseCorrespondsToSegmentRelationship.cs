namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<SegmentResponseCorrespondsToSegmentRelationship>
    {
        public SegmentResponseCorrespondsToSegmentRelationship()
        {
            Name = "correspondsToSegment";
        }

        public SegmentResponseCorrespondsToSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseCorrespondsToSegmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseCorrespondsToSegmentRelationship);
        }

        public bool Equals(SegmentResponseCorrespondsToSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseCorrespondsToSegmentRelationship? left, SegmentResponseCorrespondsToSegmentRelationship? right)
        {
            return EqualityComparer<SegmentResponseCorrespondsToSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseCorrespondsToSegmentRelationship? left, SegmentResponseCorrespondsToSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseCorrespondsToSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}