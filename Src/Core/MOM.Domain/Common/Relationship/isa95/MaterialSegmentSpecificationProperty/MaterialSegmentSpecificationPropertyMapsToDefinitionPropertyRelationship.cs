namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship>
    {
        public MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship()
        {
            Name = "mapsToDefinitionProperty";
        }

        public MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship? left, MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship? left, MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}