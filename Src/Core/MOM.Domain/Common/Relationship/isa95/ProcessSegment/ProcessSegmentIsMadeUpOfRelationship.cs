namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<ProcessSegmentIsMadeUpOfRelationship>
    {
        public ProcessSegmentIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public ProcessSegmentIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentIsMadeUpOfRelationship);
        }

        public bool Equals(ProcessSegmentIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentIsMadeUpOfRelationship? left, ProcessSegmentIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<ProcessSegmentIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentIsMadeUpOfRelationship? left, ProcessSegmentIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}