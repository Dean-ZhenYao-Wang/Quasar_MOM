namespace MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement
{
    public class OperationsTestRequirementSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<OperationsTestRequirementSpecifiesRelationship>
    {
        public OperationsTestRequirementSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public OperationsTestRequirementSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.OperationsTestRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsTestRequirementSpecifiesRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsTestRequirementSpecifiesRelationship);
        }

        public bool Equals(OperationsTestRequirementSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsTestRequirementSpecifiesRelationship? left, OperationsTestRequirementSpecifiesRelationship? right)
        {
            return EqualityComparer<OperationsTestRequirementSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsTestRequirementSpecifiesRelationship? left, OperationsTestRequirementSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsTestRequirementSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}