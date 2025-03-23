namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement>, IEquatable<PhysicalAssetRequirementIsMadeUpOfRelationship>
    {
        public PhysicalAssetRequirementIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PhysicalAssetRequirementIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementIsMadeUpOfRelationship);
        }

        public bool Equals(PhysicalAssetRequirementIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementIsMadeUpOfRelationship? left, PhysicalAssetRequirementIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementIsMadeUpOfRelationship? left, PhysicalAssetRequirementIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}