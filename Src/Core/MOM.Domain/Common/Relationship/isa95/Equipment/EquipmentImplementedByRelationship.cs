namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentImplementedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<EquipmentImplementedByRelationship>
    {
        public EquipmentImplementedByRelationship()
        {
            Name = "implementedBy";
        }

        public EquipmentImplementedByRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentImplementedByRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentImplementedByRelationship);
        }

        public bool Equals(EquipmentImplementedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentImplementedByRelationship? left, EquipmentImplementedByRelationship? right)
        {
            return EqualityComparer<EquipmentImplementedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentImplementedByRelationship? left, EquipmentImplementedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentImplementedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}