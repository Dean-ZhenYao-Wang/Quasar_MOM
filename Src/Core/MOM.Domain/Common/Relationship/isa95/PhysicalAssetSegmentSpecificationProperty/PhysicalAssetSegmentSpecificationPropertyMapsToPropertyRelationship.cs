namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecificationProperty
{
    public class PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>, IEquatable<PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship>
    {
        public PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship? left, PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship? left, PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSegmentSpecificationPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}