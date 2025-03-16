namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>, IEquatable<OperationsSegmentContainsMaterialRelationship>
    {
        public OperationsSegmentContainsMaterialRelationship()
        {
            Name = "containsMaterial";
        }

        public OperationsSegmentContainsMaterialRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentContainsMaterialRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentContainsMaterialRelationship);
        }

        public bool Equals(OperationsSegmentContainsMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentContainsMaterialRelationship? left, OperationsSegmentContainsMaterialRelationship? right)
        {
            return EqualityComparer<OperationsSegmentContainsMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentContainsMaterialRelationship? left, OperationsSegmentContainsMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentContainsMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}