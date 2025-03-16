namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialClassIncludesPropertiesOfRelationship>
    {
        public MaterialClassIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public MaterialClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialClassIncludesPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClassIncludesPropertiesOfRelationship);
        }

        public bool Equals(MaterialClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialClassIncludesPropertiesOfRelationship? left, MaterialClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<MaterialClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClassIncludesPropertiesOfRelationship? left, MaterialClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}