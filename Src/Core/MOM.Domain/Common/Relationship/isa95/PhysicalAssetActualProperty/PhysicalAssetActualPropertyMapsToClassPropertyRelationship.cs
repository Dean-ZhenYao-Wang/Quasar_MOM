namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty
{
    public class PhysicalAssetActualPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>, IEquatable<PhysicalAssetActualPropertyMapsToClassPropertyRelationship>
    {
        public PhysicalAssetActualPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PhysicalAssetActualPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PhysicalAssetActualPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualPropertyMapsToClassPropertyRelationship? left, PhysicalAssetActualPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualPropertyMapsToClassPropertyRelationship? left, PhysicalAssetActualPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}