namespace MOM.Domain.Common.Relationship.isa95.EquipmentSpecificationProperty
{
    public class EquipmentSpecificationPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>, IEquatable<EquipmentSpecificationPropertyMapsToPropertyRelationship>
    {
        public EquipmentSpecificationPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public EquipmentSpecificationPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSpecificationPropertyMapsToPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecificationPropertyMapsToPropertyRelationship);
        }

        public bool Equals(EquipmentSpecificationPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSpecificationPropertyMapsToPropertyRelationship? left, EquipmentSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentSpecificationPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecificationPropertyMapsToPropertyRelationship? left, EquipmentSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSpecificationPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}