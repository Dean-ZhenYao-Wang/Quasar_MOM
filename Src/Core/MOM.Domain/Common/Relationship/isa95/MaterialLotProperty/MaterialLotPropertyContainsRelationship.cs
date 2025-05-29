namespace MOM.Domain.Common.Relationship.isa95.MaterialLotProperty
{
    public class MaterialLotPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialLotPropertyContainsRelationship>
    {
        public MaterialLotPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialLotPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotPropertyContainsRelationship);
        }

        public bool Equals(MaterialLotPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotPropertyContainsRelationship? left, MaterialLotPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialLotPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotPropertyContainsRelationship? left, MaterialLotPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}