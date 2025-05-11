namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsDataRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData>, IEquatable<SegmentResponseContainsDataRelationship>
    {
        public SegmentResponseContainsDataRelationship()
        {
            Name = "containsData";
        }

        public SegmentResponseContainsDataRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseContainsDataRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseContainsDataRelationship);
        }

        public bool Equals(SegmentResponseContainsDataRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseContainsDataRelationship? left, SegmentResponseContainsDataRelationship? right)
        {
            return EqualityComparer<SegmentResponseContainsDataRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseContainsDataRelationship? left, SegmentResponseContainsDataRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseContainsDataRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}