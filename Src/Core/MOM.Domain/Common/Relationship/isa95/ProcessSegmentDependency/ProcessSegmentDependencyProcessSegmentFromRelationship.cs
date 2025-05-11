namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentDependency
{
    public class ProcessSegmentDependencyProcessSegmentFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<ProcessSegmentDependencyProcessSegmentFromRelationship>
    {
        public ProcessSegmentDependencyProcessSegmentFromRelationship()
        {
            Name = "processSegmentFrom";
        }

        public ProcessSegmentDependencyProcessSegmentFromRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentDependency source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentDependencyProcessSegmentFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentDependencyProcessSegmentFromRelationship);
        }

        public bool Equals(ProcessSegmentDependencyProcessSegmentFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentDependencyProcessSegmentFromRelationship? left, ProcessSegmentDependencyProcessSegmentFromRelationship? right)
        {
            return EqualityComparer<ProcessSegmentDependencyProcessSegmentFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentDependencyProcessSegmentFromRelationship? left, ProcessSegmentDependencyProcessSegmentFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentDependencyProcessSegmentFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}