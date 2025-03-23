namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse>, IEquatable<SegmentResponseIsMadeUpOfRelationship>
    {
        public SegmentResponseIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public SegmentResponseIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseIsMadeUpOfRelationship);
        }

        public bool Equals(SegmentResponseIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseIsMadeUpOfRelationship? left, SegmentResponseIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<SegmentResponseIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseIsMadeUpOfRelationship? left, SegmentResponseIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}