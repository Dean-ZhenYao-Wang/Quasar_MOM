namespace MOM.Domain.Common.Relationship.isa95.EquipmentCapabilityProperty
{
    public class EquipmentCapabilityPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentCapabilityPropertyMapsToClassPropertyRelationship>
    {
        public EquipmentCapabilityPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public EquipmentCapabilityPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentCapabilityPropertyMapsToClassPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapabilityPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(EquipmentCapabilityPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentCapabilityPropertyMapsToClassPropertyRelationship? left, EquipmentCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentCapabilityPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapabilityPropertyMapsToClassPropertyRelationship? left, EquipmentCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentCapabilityPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}