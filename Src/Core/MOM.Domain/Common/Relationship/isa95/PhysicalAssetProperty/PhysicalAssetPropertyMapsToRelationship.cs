namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetProperty
{
    public class PhysicalAssetPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>, IEquatable<PhysicalAssetPropertyMapsToRelationship>
    {
        public PhysicalAssetPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public PhysicalAssetPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetPropertyMapsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetPropertyMapsToRelationship);
        }

        public bool Equals(PhysicalAssetPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetPropertyMapsToRelationship? left, PhysicalAssetPropertyMapsToRelationship? right)
        {
            return EqualityComparer<PhysicalAssetPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetPropertyMapsToRelationship? left, PhysicalAssetPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}