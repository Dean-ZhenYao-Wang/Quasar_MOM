namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecificationProperty
{
    public class EquipmentSpecificationPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentSpecificationPropertyMapsToClassPropertyRelationship>
    {
        public EquipmentSpecificationPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public EquipmentSpecificationPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSpecificationPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(EquipmentSpecificationPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSpecificationPropertyMapsToClassPropertyRelationship? left, EquipmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentSpecificationPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationPropertyMapsToClassPropertyRelationship? left, EquipmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSpecificationPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}