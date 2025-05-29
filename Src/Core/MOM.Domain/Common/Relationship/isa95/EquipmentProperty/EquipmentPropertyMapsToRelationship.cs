namespace MOM.Domain.Common.Relationship.isa95.EquipmentProperty
{
    public class EquipmentPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentPropertyMapsToRelationship>
    {
        public EquipmentPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public EquipmentPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentPropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentPropertyMapsToRelationship);
        }

        public bool Equals(EquipmentPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentPropertyMapsToRelationship? left, EquipmentPropertyMapsToRelationship? right)
        {
            return EqualityComparer<EquipmentPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentPropertyMapsToRelationship? left, EquipmentPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}