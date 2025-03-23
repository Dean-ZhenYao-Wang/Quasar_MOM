namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty
{
    public class EquipmentRequirementPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>, IEquatable<EquipmentRequirementPropertyMapsToPropertyRelationship>
    {
        public EquipmentRequirementPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public EquipmentRequirementPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementPropertyMapsToPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementPropertyMapsToPropertyRelationship);
        }

        public bool Equals(EquipmentRequirementPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementPropertyMapsToPropertyRelationship? left, EquipmentRequirementPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementPropertyMapsToPropertyRelationship? left, EquipmentRequirementPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}