namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationEvaluatesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty>, IEquatable<TestSpecificationEvaluatesRelationship>
    {
        public TestSpecificationEvaluatesRelationship()
        {
            Name = "evaluates";
        }

        public TestSpecificationEvaluatesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestSpecificationEvaluatesRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationEvaluatesRelationship);
        }

        public bool Equals(TestSpecificationEvaluatesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestSpecificationEvaluatesRelationship? left, TestSpecificationEvaluatesRelationship? right)
        {
            return EqualityComparer<TestSpecificationEvaluatesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationEvaluatesRelationship? left, TestSpecificationEvaluatesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestSpecificationEvaluatesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}