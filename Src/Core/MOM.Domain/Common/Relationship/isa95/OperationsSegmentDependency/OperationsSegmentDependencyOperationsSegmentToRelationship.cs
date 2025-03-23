namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentDependency
{
    public class OperationsSegmentDependencyOperationsSegmentToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsSegmentDependencyOperationsSegmentToRelationship>
    {
        public OperationsSegmentDependencyOperationsSegmentToRelationship()
        {
            Name = "operationsSegmentTo";
        }

        public OperationsSegmentDependencyOperationsSegmentToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegmentDependency source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentDependencyOperationsSegmentToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentDependencyOperationsSegmentToRelationship);
        }

        public bool Equals(OperationsSegmentDependencyOperationsSegmentToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentDependencyOperationsSegmentToRelationship? left, OperationsSegmentDependencyOperationsSegmentToRelationship? right)
        {
            return EqualityComparer<OperationsSegmentDependencyOperationsSegmentToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentDependencyOperationsSegmentToRelationship? left, OperationsSegmentDependencyOperationsSegmentToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentDependencyOperationsSegmentToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}