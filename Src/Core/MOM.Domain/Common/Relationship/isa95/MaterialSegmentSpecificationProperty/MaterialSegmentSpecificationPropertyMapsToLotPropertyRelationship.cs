namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship>
    {
        public MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship()
        {
            Name = "mapsToLotProperty";
        }

        public MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship? left, MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship? left, MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}