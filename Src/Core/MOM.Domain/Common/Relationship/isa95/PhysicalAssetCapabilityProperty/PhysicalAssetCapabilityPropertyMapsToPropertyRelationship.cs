namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapabilityProperty
{
    public class PhysicalAssetCapabilityPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>, IEquatable<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship>
    {
        public PhysicalAssetCapabilityPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PhysicalAssetCapabilityPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityPropertyMapsToPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityPropertyMapsToPropertyRelationship? left, PhysicalAssetCapabilityPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityPropertyMapsToPropertyRelationship? left, PhysicalAssetCapabilityPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}