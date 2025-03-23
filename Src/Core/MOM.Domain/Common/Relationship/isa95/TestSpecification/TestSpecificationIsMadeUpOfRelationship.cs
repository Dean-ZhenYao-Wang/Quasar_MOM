namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<TestSpecificationIsMadeUpOfRelationship>
    {
        public TestSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public TestSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestSpecificationIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(TestSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestSpecificationIsMadeUpOfRelationship? left, TestSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<TestSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationIsMadeUpOfRelationship? left, TestSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}