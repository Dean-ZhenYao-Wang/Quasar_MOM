namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship>
    {
        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship()
        {
            Name = "correspondsToPhysicalAssetClass";
        }

        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship? left, PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityCorrespondsToPhysicalAssetClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}