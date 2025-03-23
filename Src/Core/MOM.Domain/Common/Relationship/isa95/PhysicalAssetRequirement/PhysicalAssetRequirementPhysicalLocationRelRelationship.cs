namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementPhysicalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PhysicalAssetRequirementPhysicalLocationRelRelationship>
    {
        public PhysicalAssetRequirementPhysicalLocationRelRelationship()
        {
            Name = "physicalLocationRel";
        }

        public PhysicalAssetRequirementPhysicalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementPhysicalLocationRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementPhysicalLocationRelRelationship);
        }

        public bool Equals(PhysicalAssetRequirementPhysicalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementPhysicalLocationRelRelationship? left, PhysicalAssetRequirementPhysicalLocationRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementPhysicalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementPhysicalLocationRelRelationship? left, PhysicalAssetRequirementPhysicalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementPhysicalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}