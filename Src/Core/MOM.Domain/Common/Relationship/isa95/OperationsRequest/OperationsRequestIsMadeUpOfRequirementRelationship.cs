namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestIsMadeUpOfRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<OperationsRequestIsMadeUpOfRequirementRelationship>
    {
        public OperationsRequestIsMadeUpOfRequirementRelationship()
        {
            Name = "isMadeUpOfRequirement";
        }

        public OperationsRequestIsMadeUpOfRequirementRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRequestIsMadeUpOfRequirementRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRequestIsMadeUpOfRequirementRelationship);
        }

        public bool Equals(OperationsRequestIsMadeUpOfRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRequestIsMadeUpOfRequirementRelationship? left, OperationsRequestIsMadeUpOfRequirementRelationship? right)
        {
            return EqualityComparer<OperationsRequestIsMadeUpOfRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRequestIsMadeUpOfRequirementRelationship? left, OperationsRequestIsMadeUpOfRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRequestIsMadeUpOfRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}