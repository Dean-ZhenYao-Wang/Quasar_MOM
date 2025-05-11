namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentHasAnExecutionDependencyOnRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<ProcessSegmentHasAnExecutionDependencyOnRelationship>
    {
        public ProcessSegmentHasAnExecutionDependencyOnRelationship()
        {
            Name = "hasAnExecutionDependencyOn";
        }

        public ProcessSegmentHasAnExecutionDependencyOnRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentHasAnExecutionDependencyOnRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentHasAnExecutionDependencyOnRelationship);
        }

        public bool Equals(ProcessSegmentHasAnExecutionDependencyOnRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentHasAnExecutionDependencyOnRelationship? left, ProcessSegmentHasAnExecutionDependencyOnRelationship? right)
        {
            return EqualityComparer<ProcessSegmentHasAnExecutionDependencyOnRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentHasAnExecutionDependencyOnRelationship? left, ProcessSegmentHasAnExecutionDependencyOnRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentHasAnExecutionDependencyOnRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}