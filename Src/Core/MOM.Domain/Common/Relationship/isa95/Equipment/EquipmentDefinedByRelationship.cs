namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentDefinedByRelationship>
    {
        public EquipmentDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public EquipmentDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentDefinedByRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentDefinedByRelationship);
        }

        public bool Equals(EquipmentDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentDefinedByRelationship? left, EquipmentDefinedByRelationship? right)
        {
            return EqualityComparer<EquipmentDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentDefinedByRelationship? left, EquipmentDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}