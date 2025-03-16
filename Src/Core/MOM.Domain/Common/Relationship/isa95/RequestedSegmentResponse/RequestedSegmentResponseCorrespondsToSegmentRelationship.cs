namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<RequestedSegmentResponseCorrespondsToSegmentRelationship>
    {
        public RequestedSegmentResponseCorrespondsToSegmentRelationship()
        {
            Name = "correspondsToSegment";
        }

        public RequestedSegmentResponseCorrespondsToSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public RequestedSegmentResponseCorrespondsToSegmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestedSegmentResponseCorrespondsToSegmentRelationship);
        }

        public bool Equals(RequestedSegmentResponseCorrespondsToSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(RequestedSegmentResponseCorrespondsToSegmentRelationship? left, RequestedSegmentResponseCorrespondsToSegmentRelationship? right)
        {
            return EqualityComparer<RequestedSegmentResponseCorrespondsToSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestedSegmentResponseCorrespondsToSegmentRelationship? left, RequestedSegmentResponseCorrespondsToSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as RequestedSegmentResponseCorrespondsToSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}