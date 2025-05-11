namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship>
    {
        public RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship()
        {
            Name = "correspondsToAProcessSegment";
        }

        public RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship);
        }

        public bool Equals(RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship? left, RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship? right)
        {
            return EqualityComparer<RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship? left, RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as RequestedSegmentResponseCorrespondsToAProcessSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}