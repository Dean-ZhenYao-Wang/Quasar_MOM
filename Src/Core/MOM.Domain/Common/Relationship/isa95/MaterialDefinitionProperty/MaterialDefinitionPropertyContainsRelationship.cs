namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinitionProperty
{
    public class MaterialDefinitionPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialDefinitionPropertyContainsRelationship>
    {
        public MaterialDefinitionPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialDefinitionPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialDefinitionPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinitionPropertyContainsRelationship);
        }

        public bool Equals(MaterialDefinitionPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialDefinitionPropertyContainsRelationship? left, MaterialDefinitionPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialDefinitionPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinitionPropertyContainsRelationship? left, MaterialDefinitionPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialDefinitionPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}