namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty
{
    public class EquipmentCapabilityPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>, IEquatable<EquipmentCapabilityPropertyMapsToPropertyRelationship>
    {
        public EquipmentCapabilityPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public EquipmentCapabilityPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityPropertyMapsToPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityPropertyMapsToPropertyRelationship);
        }

        public bool Equals(EquipmentCapabilityPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityPropertyMapsToPropertyRelationship? left, EquipmentCapabilityPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityPropertyMapsToPropertyRelationship? left, EquipmentCapabilityPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}