namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialDefinitionHasPropertiesOfRelationship>
    {
        public MaterialDefinitionHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public MaterialDefinitionHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialDefinitionHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinitionHasPropertiesOfRelationship);
        }

        public bool Equals(MaterialDefinitionHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialDefinitionHasPropertiesOfRelationship? left, MaterialDefinitionHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<MaterialDefinitionHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinitionHasPropertiesOfRelationship? left, MaterialDefinitionHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialDefinitionHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}