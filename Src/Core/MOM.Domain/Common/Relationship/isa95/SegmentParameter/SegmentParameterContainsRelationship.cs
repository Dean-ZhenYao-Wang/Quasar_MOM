namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter>, IEquatable<SegmentParameterContainsRelationship>
    {
        public SegmentParameterContainsRelationship()
        {
            Name = "contains";
        }

        public SegmentParameterContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentParameterContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentParameterContainsRelationship);
        }

        public bool Equals(SegmentParameterContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentParameterContainsRelationship? left, SegmentParameterContainsRelationship? right)
        {
            return EqualityComparer<SegmentParameterContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentParameterContainsRelationship? left, SegmentParameterContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentParameterContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}