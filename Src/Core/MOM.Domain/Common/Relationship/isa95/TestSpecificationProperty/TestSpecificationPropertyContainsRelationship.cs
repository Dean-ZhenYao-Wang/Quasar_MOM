namespace MOM.Domain.Common.Relationship.isa95.TestSpecificationProperty
{
    public class TestSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationProperty>, IEquatable<TestSpecificationPropertyContainsRelationship>
    {
        public TestSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public TestSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestSpecificationPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationPropertyContainsRelationship);
        }

        public bool Equals(TestSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestSpecificationPropertyContainsRelationship? left, TestSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<TestSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationPropertyContainsRelationship? left, TestSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}