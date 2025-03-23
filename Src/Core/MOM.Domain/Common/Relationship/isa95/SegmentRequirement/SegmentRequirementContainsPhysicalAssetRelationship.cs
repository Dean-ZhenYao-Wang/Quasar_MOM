namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement>, IEquatable<SegmentRequirementContainsPhysicalAssetRelationship>
    {
        public SegmentRequirementContainsPhysicalAssetRelationship()
        {
            Name = "containsPhysicalAsset";
        }

        public SegmentRequirementContainsPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementContainsPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementContainsPhysicalAssetRelationship);
        }

        public bool Equals(SegmentRequirementContainsPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementContainsPhysicalAssetRelationship? left, SegmentRequirementContainsPhysicalAssetRelationship? right)
        {
            return EqualityComparer<SegmentRequirementContainsPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementContainsPhysicalAssetRelationship? left, SegmentRequirementContainsPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementContainsPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}