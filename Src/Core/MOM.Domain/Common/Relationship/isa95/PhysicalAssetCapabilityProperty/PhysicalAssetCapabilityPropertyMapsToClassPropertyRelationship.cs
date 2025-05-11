namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapabilityProperty
{
    public class PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>, IEquatable<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship>
    {
        public PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship? left, PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship? left, PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}