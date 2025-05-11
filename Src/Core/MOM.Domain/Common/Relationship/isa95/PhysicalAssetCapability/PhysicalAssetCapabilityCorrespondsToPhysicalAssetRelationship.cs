namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship>
    {
        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship()
        {
            Name = "correspondsToPhysicalAsset";
        }

        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship? left, PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityCorrespondsToPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}