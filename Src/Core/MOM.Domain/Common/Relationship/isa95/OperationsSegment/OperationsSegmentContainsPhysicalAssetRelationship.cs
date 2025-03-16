namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification>, IEquatable<OperationsSegmentContainsPhysicalAssetRelationship>
    {
        public OperationsSegmentContainsPhysicalAssetRelationship()
        {
            Name = "containsPhysicalAsset";
        }

        public OperationsSegmentContainsPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentContainsPhysicalAssetRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentContainsPhysicalAssetRelationship);
        }

        public bool Equals(OperationsSegmentContainsPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentContainsPhysicalAssetRelationship? left, OperationsSegmentContainsPhysicalAssetRelationship? right)
        {
            return EqualityComparer<OperationsSegmentContainsPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentContainsPhysicalAssetRelationship? left, OperationsSegmentContainsPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentContainsPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}