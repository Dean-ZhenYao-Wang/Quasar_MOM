namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentHasAnExecutionDependencyOnRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsSegmentHasAnExecutionDependencyOnRelationship>
    {
        public OperationsSegmentHasAnExecutionDependencyOnRelationship()
        {
            Name = "hasAnExecutionDependencyOn";
        }

        public OperationsSegmentHasAnExecutionDependencyOnRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentHasAnExecutionDependencyOnRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentHasAnExecutionDependencyOnRelationship);
        }

        public bool Equals(OperationsSegmentHasAnExecutionDependencyOnRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentHasAnExecutionDependencyOnRelationship? left, OperationsSegmentHasAnExecutionDependencyOnRelationship? right)
        {
            return EqualityComparer<OperationsSegmentHasAnExecutionDependencyOnRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentHasAnExecutionDependencyOnRelationship? left, OperationsSegmentHasAnExecutionDependencyOnRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentHasAnExecutionDependencyOnRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}