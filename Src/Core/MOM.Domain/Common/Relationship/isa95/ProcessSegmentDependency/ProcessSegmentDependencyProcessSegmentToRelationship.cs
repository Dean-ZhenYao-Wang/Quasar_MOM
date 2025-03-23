namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentDependency
{
    public class ProcessSegmentDependencyProcessSegmentToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<ProcessSegmentDependencyProcessSegmentToRelationship>
    {
        public ProcessSegmentDependencyProcessSegmentToRelationship()
        {
            Name = "processSegmentTo";
        }

        public ProcessSegmentDependencyProcessSegmentToRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentDependency source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentDependencyProcessSegmentToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentDependencyProcessSegmentToRelationship);
        }

        public bool Equals(ProcessSegmentDependencyProcessSegmentToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentDependencyProcessSegmentToRelationship? left, ProcessSegmentDependencyProcessSegmentToRelationship? right)
        {
            return EqualityComparer<ProcessSegmentDependencyProcessSegmentToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentDependencyProcessSegmentToRelationship? left, ProcessSegmentDependencyProcessSegmentToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentDependencyProcessSegmentToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}