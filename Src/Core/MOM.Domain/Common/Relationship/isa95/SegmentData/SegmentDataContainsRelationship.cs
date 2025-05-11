namespace MOM.Domain.Common.Relationship.isa95.SegmentData
{
    public class SegmentDataContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData>, IEquatable<SegmentDataContainsRelationship>
    {
        public SegmentDataContainsRelationship()
        {
            Name = "contains";
        }

        public SegmentDataContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentDataContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentDataContainsRelationship);
        }

        public bool Equals(SegmentDataContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentDataContainsRelationship? left, SegmentDataContainsRelationship? right)
        {
            return EqualityComparer<SegmentDataContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentDataContainsRelationship? left, SegmentDataContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentDataContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}