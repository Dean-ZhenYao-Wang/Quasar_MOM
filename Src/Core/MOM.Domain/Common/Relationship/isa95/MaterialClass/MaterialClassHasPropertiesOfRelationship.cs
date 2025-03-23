namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialClassHasPropertiesOfRelationship>
    {
        public MaterialClassHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public MaterialClassHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialClassHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClassHasPropertiesOfRelationship);
        }

        public bool Equals(MaterialClassHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialClassHasPropertiesOfRelationship? left, MaterialClassHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<MaterialClassHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClassHasPropertiesOfRelationship? left, MaterialClassHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialClassHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}