namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty>, IEquatable<MaterialSpecificationPropertyContainsRelationship>
    {
        public MaterialSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationPropertyContainsRelationship);
        }

        public bool Equals(MaterialSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationPropertyContainsRelationship? left, MaterialSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationPropertyContainsRelationship? left, MaterialSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}