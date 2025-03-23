namespace MOM.Domain.Common.Relationship.isa95.TestableObject
{
    public class TestableObjectSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<TestableObjectSpecifiesRelationship>
    {
        public TestableObjectSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public TestableObjectSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestableObjectSpecifiesRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestableObjectSpecifiesRelationship);
        }

        public bool Equals(TestableObjectSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestableObjectSpecifiesRelationship? left, TestableObjectSpecifiesRelationship? right)
        {
            return EqualityComparer<TestableObjectSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestableObjectSpecifiesRelationship? left, TestableObjectSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestableObjectSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}