namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<MaterialSegmentSpecificationSpecifiesRelationship>
    {
        public MaterialSegmentSpecificationSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public MaterialSegmentSpecificationSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationSpecifiesRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationSpecifiesRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationSpecifiesRelationship? left, MaterialSegmentSpecificationSpecifiesRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationSpecifiesRelationship? left, MaterialSegmentSpecificationSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}