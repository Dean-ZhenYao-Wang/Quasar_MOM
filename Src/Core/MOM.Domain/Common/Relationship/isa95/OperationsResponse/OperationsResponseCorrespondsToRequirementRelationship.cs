namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<OperationsResponseCorrespondsToRequirementRelationship>
    {
        public OperationsResponseCorrespondsToRequirementRelationship()
        {
            Name = "correspondsToRequirement";
        }

        public OperationsResponseCorrespondsToRequirementRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsResponseCorrespondsToRequirementRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsResponseCorrespondsToRequirementRelationship);
        }

        public bool Equals(OperationsResponseCorrespondsToRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsResponseCorrespondsToRequirementRelationship? left, OperationsResponseCorrespondsToRequirementRelationship? right)
        {
            return EqualityComparer<OperationsResponseCorrespondsToRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsResponseCorrespondsToRequirementRelationship? left, OperationsResponseCorrespondsToRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsResponseCorrespondsToRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}