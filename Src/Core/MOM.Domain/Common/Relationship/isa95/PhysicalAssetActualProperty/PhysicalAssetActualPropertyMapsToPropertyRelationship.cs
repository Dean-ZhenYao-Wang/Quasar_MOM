namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty
{
    public class PhysicalAssetActualPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>, IEquatable<PhysicalAssetActualPropertyMapsToPropertyRelationship>
    {
        public PhysicalAssetActualPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PhysicalAssetActualPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualPropertyMapsToPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PhysicalAssetActualPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualPropertyMapsToPropertyRelationship? left, PhysicalAssetActualPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualPropertyMapsToPropertyRelationship? left, PhysicalAssetActualPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}