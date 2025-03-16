namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialSublotHasValuesOfRelationship>
    {
        public MaterialSublotHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public MaterialSublotHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSublotHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublotHasValuesOfRelationship);
        }

        public bool Equals(MaterialSublotHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSublotHasValuesOfRelationship? left, MaterialSublotHasValuesOfRelationship? right)
        {
            return EqualityComparer<MaterialSublotHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublotHasValuesOfRelationship? left, MaterialSublotHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSublotHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}