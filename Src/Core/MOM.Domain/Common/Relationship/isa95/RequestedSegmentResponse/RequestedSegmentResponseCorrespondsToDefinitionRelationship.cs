namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>, IEquatable<RequestedSegmentResponseCorrespondsToDefinitionRelationship>
    {
        public RequestedSegmentResponseCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public RequestedSegmentResponseCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public RequestedSegmentResponseCorrespondsToDefinitionRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestedSegmentResponseCorrespondsToDefinitionRelationship);
        }

        public bool Equals(RequestedSegmentResponseCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(RequestedSegmentResponseCorrespondsToDefinitionRelationship? left, RequestedSegmentResponseCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<RequestedSegmentResponseCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestedSegmentResponseCorrespondsToDefinitionRelationship? left, RequestedSegmentResponseCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as RequestedSegmentResponseCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}