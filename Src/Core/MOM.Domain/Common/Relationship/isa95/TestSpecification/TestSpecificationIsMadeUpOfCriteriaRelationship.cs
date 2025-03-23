namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationIsMadeUpOfCriteriaRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria>, IEquatable<TestSpecificationIsMadeUpOfCriteriaRelationship>
    {
        public TestSpecificationIsMadeUpOfCriteriaRelationship()
        {
            Name = "isMadeUpOfCriteria";
        }

        public TestSpecificationIsMadeUpOfCriteriaRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestSpecificationIsMadeUpOfCriteriaRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationIsMadeUpOfCriteriaRelationship);
        }

        public bool Equals(TestSpecificationIsMadeUpOfCriteriaRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestSpecificationIsMadeUpOfCriteriaRelationship? left, TestSpecificationIsMadeUpOfCriteriaRelationship? right)
        {
            return EqualityComparer<TestSpecificationIsMadeUpOfCriteriaRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationIsMadeUpOfCriteriaRelationship? left, TestSpecificationIsMadeUpOfCriteriaRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestSpecificationIsMadeUpOfCriteriaRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}