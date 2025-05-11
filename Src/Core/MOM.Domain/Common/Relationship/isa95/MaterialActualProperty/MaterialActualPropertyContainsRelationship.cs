namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty>, IEquatable<MaterialActualPropertyContainsRelationship>
    {
        public MaterialActualPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialActualPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualPropertyContainsRelationship);
        }

        public bool Equals(MaterialActualPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualPropertyContainsRelationship? left, MaterialActualPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialActualPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualPropertyContainsRelationship? left, MaterialActualPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}