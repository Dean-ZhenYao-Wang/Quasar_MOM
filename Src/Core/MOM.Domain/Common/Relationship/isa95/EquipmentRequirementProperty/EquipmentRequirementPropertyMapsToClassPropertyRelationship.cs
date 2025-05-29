namespace MOM.Domain.Common.Relationship.isa95.EquipmentRequirementProperty
{
    public class EquipmentRequirementPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentRequirementPropertyMapsToClassPropertyRelationship>
    {
        public EquipmentRequirementPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public EquipmentRequirementPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentRequirementPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirementPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(EquipmentRequirementPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentRequirementPropertyMapsToClassPropertyRelationship? left, EquipmentRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentRequirementPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirementPropertyMapsToClassPropertyRelationship? left, EquipmentRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentRequirementPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}