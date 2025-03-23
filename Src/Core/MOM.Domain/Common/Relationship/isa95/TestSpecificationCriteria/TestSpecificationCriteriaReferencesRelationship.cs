namespace MOM.Domain.Common.Relationship.isa95.TestSpecificationCriteria
{
    public class TestSpecificationCriteriaReferencesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty>, IEquatable<TestSpecificationCriteriaReferencesRelationship>
    {
        public TestSpecificationCriteriaReferencesRelationship()
        {
            Name = "references";
        }

        public TestSpecificationCriteriaReferencesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public TestSpecificationCriteriaReferencesRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationCriteriaReferencesRelationship);
        }

        public bool Equals(TestSpecificationCriteriaReferencesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TestSpecificationCriteriaReferencesRelationship? left, TestSpecificationCriteriaReferencesRelationship? right)
        {
            return EqualityComparer<TestSpecificationCriteriaReferencesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationCriteriaReferencesRelationship? left, TestSpecificationCriteriaReferencesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TestSpecificationCriteriaReferencesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}