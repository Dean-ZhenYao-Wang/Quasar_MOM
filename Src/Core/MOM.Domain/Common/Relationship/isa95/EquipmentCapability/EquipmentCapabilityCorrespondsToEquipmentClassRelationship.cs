namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapability
{
    public class EquipmentCapabilityCorrespondsToEquipmentClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentCapabilityCorrespondsToEquipmentClassRelationship>
    {
        public EquipmentCapabilityCorrespondsToEquipmentClassRelationship()
        {
            Name = "correspondsToEquipmentClass";
        }

        public EquipmentCapabilityCorrespondsToEquipmentClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityCorrespondsToEquipmentClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityCorrespondsToEquipmentClassRelationship);
        }

        public bool Equals(EquipmentCapabilityCorrespondsToEquipmentClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityCorrespondsToEquipmentClassRelationship? left, EquipmentCapabilityCorrespondsToEquipmentClassRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityCorrespondsToEquipmentClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityCorrespondsToEquipmentClassRelationship? left, EquipmentCapabilityCorrespondsToEquipmentClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityCorrespondsToEquipmentClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}