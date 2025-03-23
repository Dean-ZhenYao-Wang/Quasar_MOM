namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentDependency>, IEquatable<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship>
    {
        public ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship()
        {
            Name = "hasAnExecutionDependencyOnSegment";
        }

        public ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentDependency target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship);
        }

        public bool Equals(ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship? left, ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship? right)
        {
            return EqualityComparer<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship? left, ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}