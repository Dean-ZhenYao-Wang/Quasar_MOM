namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinitionProperty
{
    public class MaterialDefinitionPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialDefinitionPropertyMapsToRelationship>
    {
        public MaterialDefinitionPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public MaterialDefinitionPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialDefinitionPropertyMapsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinitionPropertyMapsToRelationship);
        }

        public bool Equals(MaterialDefinitionPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialDefinitionPropertyMapsToRelationship? left, MaterialDefinitionPropertyMapsToRelationship? right)
        {
            return EqualityComparer<MaterialDefinitionPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinitionPropertyMapsToRelationship? left, MaterialDefinitionPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialDefinitionPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}