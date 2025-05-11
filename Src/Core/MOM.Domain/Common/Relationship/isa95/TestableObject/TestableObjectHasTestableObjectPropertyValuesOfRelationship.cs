namespace MOM.Domain.Common.Relationship.isa95.TestableObject
{
    public class TestableObjectHasTestableObjectPropertyValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>, IEquatable<TestableObjectHasTestableObjectPropertyValuesOfRelationship>
    {
        public TestableObjectHasTestableObjectPropertyValuesOfRelationship()
        {
            Name = "hasTestableObjectPropertyValuesOf";
        }

        public TestableObjectHasTestableObjectPropertyValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestableObjectHasTestableObjectPropertyValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestableObjectHasTestableObjectPropertyValuesOfRelationship);
        }

        public bool Equals(TestableObjectHasTestableObjectPropertyValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestableObjectHasTestableObjectPropertyValuesOfRelationship? left, TestableObjectHasTestableObjectPropertyValuesOfRelationship? right)
        {
            return EqualityComparer<TestableObjectHasTestableObjectPropertyValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestableObjectHasTestableObjectPropertyValuesOfRelationship? left, TestableObjectHasTestableObjectPropertyValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestableObjectHasTestableObjectPropertyValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}