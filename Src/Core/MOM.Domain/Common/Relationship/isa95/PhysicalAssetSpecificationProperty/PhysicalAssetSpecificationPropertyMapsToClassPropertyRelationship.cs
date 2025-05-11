namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecificationProperty
{
    public class PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>, IEquatable<PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship>
    {
        public PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship? left, PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship? left, PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}