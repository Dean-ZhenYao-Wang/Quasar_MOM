namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialLotHasValuesOfRelationship>
    {
        public MaterialLotHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public MaterialLotHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotHasValuesOfRelationship);
        }

        public bool Equals(MaterialLotHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotHasValuesOfRelationship? left, MaterialLotHasValuesOfRelationship? right)
        {
            return EqualityComparer<MaterialLotHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotHasValuesOfRelationship? left, MaterialLotHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}