namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot,Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialSublotIsMadeUpOfRelationship>
    {
        public MaterialSublotIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public MaterialSublotIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSublotIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublotIsMadeUpOfRelationship);
        }

        public bool Equals(MaterialSublotIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSublotIsMadeUpOfRelationship? left, MaterialSublotIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<MaterialSublotIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublotIsMadeUpOfRelationship? left, MaterialSublotIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSublotIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}