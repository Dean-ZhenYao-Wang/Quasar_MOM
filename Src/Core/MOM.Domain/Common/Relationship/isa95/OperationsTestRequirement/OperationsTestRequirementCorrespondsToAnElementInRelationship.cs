namespace MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement
{
    public class OperationsTestRequirementCorrespondsToAnElementInRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject>, IEquatable<OperationsTestRequirementCorrespondsToAnElementInRelationship>
    {
        public OperationsTestRequirementCorrespondsToAnElementInRelationship()
        {
            Name = "correspondsToAnElementIn";
        }

        public OperationsTestRequirementCorrespondsToAnElementInRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.OperationsTestRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsTestRequirementCorrespondsToAnElementInRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsTestRequirementCorrespondsToAnElementInRelationship);
        }

        public bool Equals(OperationsTestRequirementCorrespondsToAnElementInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsTestRequirementCorrespondsToAnElementInRelationship? left, OperationsTestRequirementCorrespondsToAnElementInRelationship? right)
        {
            return EqualityComparer<OperationsTestRequirementCorrespondsToAnElementInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsTestRequirementCorrespondsToAnElementInRelationship? left, OperationsTestRequirementCorrespondsToAnElementInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsTestRequirementCorrespondsToAnElementInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}