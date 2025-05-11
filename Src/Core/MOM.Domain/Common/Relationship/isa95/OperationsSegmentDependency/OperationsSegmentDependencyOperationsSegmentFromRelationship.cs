namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentDependency
{
    public class OperationsSegmentDependencyOperationsSegmentFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsSegmentDependencyOperationsSegmentFromRelationship>
    {
        public OperationsSegmentDependencyOperationsSegmentFromRelationship()
        {
            Name = "operationsSegmentFrom";
        }

        public OperationsSegmentDependencyOperationsSegmentFromRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegmentDependency source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentDependencyOperationsSegmentFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentDependencyOperationsSegmentFromRelationship);
        }

        public bool Equals(OperationsSegmentDependencyOperationsSegmentFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentDependencyOperationsSegmentFromRelationship? left, OperationsSegmentDependencyOperationsSegmentFromRelationship? right)
        {
            return EqualityComparer<OperationsSegmentDependencyOperationsSegmentFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentDependencyOperationsSegmentFromRelationship? left, OperationsSegmentDependencyOperationsSegmentFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentDependencyOperationsSegmentFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}