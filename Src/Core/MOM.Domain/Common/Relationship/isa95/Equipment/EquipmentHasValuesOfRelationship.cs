namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>, IEquatable<EquipmentHasValuesOfRelationship>
    {
        public EquipmentHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public EquipmentHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentHasValuesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentHasValuesOfRelationship);
        }

        public bool Equals(EquipmentHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentHasValuesOfRelationship? left, EquipmentHasValuesOfRelationship? right)
        {
            return EqualityComparer<EquipmentHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentHasValuesOfRelationship? left, EquipmentHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}