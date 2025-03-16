namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty>, IEquatable<MaterialSegmentSpecificationPropertyContainsRelationship>
    {
        public MaterialSegmentSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialSegmentSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationPropertyContainsRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationPropertyContainsRelationship? left, MaterialSegmentSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationPropertyContainsRelationship? left, MaterialSegmentSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}