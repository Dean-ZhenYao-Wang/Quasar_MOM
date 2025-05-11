namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterCorrespondsToProcessRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter>, IEquatable<SegmentParameterCorrespondsToProcessRelationship>
    {
        public SegmentParameterCorrespondsToProcessRelationship()
        {
            Name = "correspondsToProcess";
        }

        public SegmentParameterCorrespondsToProcessRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentParameterCorrespondsToProcessRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentParameterCorrespondsToProcessRelationship);
        }

        public bool Equals(SegmentParameterCorrespondsToProcessRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentParameterCorrespondsToProcessRelationship? left, SegmentParameterCorrespondsToProcessRelationship? right)
        {
            return EqualityComparer<SegmentParameterCorrespondsToProcessRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentParameterCorrespondsToProcessRelationship? left, SegmentParameterCorrespondsToProcessRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentParameterCorrespondsToProcessRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}