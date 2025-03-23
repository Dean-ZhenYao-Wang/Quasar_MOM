namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationSpecifiesTestForObjectRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject>, IEquatable<TestSpecificationSpecifiesTestForObjectRelationship>
    {
        public TestSpecificationSpecifiesTestForObjectRelationship()
        {
            Name = "specifiesTestForObject";
        }

        public TestSpecificationSpecifiesTestForObjectRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestSpecificationSpecifiesTestForObjectRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationSpecifiesTestForObjectRelationship);
        }

        public bool Equals(TestSpecificationSpecifiesTestForObjectRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestSpecificationSpecifiesTestForObjectRelationship? left, TestSpecificationSpecifiesTestForObjectRelationship? right)
        {
            return EqualityComparer<TestSpecificationSpecifiesTestForObjectRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationSpecifiesTestForObjectRelationship? left, TestSpecificationSpecifiesTestForObjectRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestSpecificationSpecifiesTestForObjectRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}