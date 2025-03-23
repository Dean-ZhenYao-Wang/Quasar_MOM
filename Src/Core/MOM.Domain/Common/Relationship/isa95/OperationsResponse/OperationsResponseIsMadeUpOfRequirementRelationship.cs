namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseIsMadeUpOfRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse>, IEquatable<OperationsResponseIsMadeUpOfRequirementRelationship>
    {
        public OperationsResponseIsMadeUpOfRequirementRelationship()
        {
            Name = "isMadeUpOfRequirement";
        }

        public OperationsResponseIsMadeUpOfRequirementRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsResponseIsMadeUpOfRequirementRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsResponseIsMadeUpOfRequirementRelationship);
        }

        public bool Equals(OperationsResponseIsMadeUpOfRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsResponseIsMadeUpOfRequirementRelationship? left, OperationsResponseIsMadeUpOfRequirementRelationship? right)
        {
            return EqualityComparer<OperationsResponseIsMadeUpOfRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsResponseIsMadeUpOfRequirementRelationship? left, OperationsResponseIsMadeUpOfRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsResponseIsMadeUpOfRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}