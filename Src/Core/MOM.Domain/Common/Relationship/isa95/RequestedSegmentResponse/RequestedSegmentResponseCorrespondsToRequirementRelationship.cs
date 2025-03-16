namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<RequestedSegmentResponseCorrespondsToRequirementRelationship>
    {
        public RequestedSegmentResponseCorrespondsToRequirementRelationship()
        {
            Name = "correspondsToRequirement";
        }

        public RequestedSegmentResponseCorrespondsToRequirementRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public RequestedSegmentResponseCorrespondsToRequirementRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestedSegmentResponseCorrespondsToRequirementRelationship);
        }

        public bool Equals(RequestedSegmentResponseCorrespondsToRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(RequestedSegmentResponseCorrespondsToRequirementRelationship? left, RequestedSegmentResponseCorrespondsToRequirementRelationship? right)
        {
            return EqualityComparer<RequestedSegmentResponseCorrespondsToRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestedSegmentResponseCorrespondsToRequirementRelationship? left, RequestedSegmentResponseCorrespondsToRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as RequestedSegmentResponseCorrespondsToRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}