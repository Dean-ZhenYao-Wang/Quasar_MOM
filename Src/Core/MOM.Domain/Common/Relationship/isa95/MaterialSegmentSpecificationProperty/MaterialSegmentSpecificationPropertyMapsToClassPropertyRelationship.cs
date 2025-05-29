namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship>
    {
        public MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship? left, MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship? left, MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}