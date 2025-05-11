namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegmentDependency>, IEquatable<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship>
    {
        public OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship()
        {
            Name = "hasAnExecutionDependencyOnSegment";
        }

        public OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegmentDependency target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship);
        }

        public bool Equals(OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship? left, OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship? right)
        {
            return EqualityComparer<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship? left, OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}