namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship>
    {
        public PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship()
        {
            Name = "correspondsToPhysicalAsset";
        }

        public PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship);
        }

        public bool Equals(PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}