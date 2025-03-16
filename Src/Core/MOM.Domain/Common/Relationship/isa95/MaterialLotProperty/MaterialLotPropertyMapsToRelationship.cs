namespace MOM.Domain.Common.Relationship.isa95.MaterialLotProperty
{
    public class MaterialLotPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialLotPropertyMapsToRelationship>
    {
        public MaterialLotPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public MaterialLotPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotPropertyMapsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotPropertyMapsToRelationship);
        }

        public bool Equals(MaterialLotPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotPropertyMapsToRelationship? left, MaterialLotPropertyMapsToRelationship? right)
        {
            return EqualityComparer<MaterialLotPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotPropertyMapsToRelationship? left, MaterialLotPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}