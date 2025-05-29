namespace MOM.Domain.Common.Relationship.isa95.MaterialClassProperty
{
    public class MaterialClassPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty,Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialClassPropertyContainsRelationship>
    {
        public MaterialClassPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialClassPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialClassPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClassPropertyContainsRelationship);
        }

        public bool Equals(MaterialClassPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialClassPropertyContainsRelationship? left, MaterialClassPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialClassPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClassPropertyContainsRelationship? left, MaterialClassPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialClassPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}