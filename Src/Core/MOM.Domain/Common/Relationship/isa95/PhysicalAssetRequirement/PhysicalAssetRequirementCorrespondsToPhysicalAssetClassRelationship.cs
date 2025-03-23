namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship>
    {
        public PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship()
        {
            Name = "correspondsToPhysicalAssetClass";
        }

        public PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship);
        }

        public bool Equals(PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}