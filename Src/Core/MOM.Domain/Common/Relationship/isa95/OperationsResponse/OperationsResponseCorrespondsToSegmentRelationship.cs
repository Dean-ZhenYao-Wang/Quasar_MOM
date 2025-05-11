namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsResponseCorrespondsToSegmentRelationship>
    {
        public OperationsResponseCorrespondsToSegmentRelationship()
        {
            Name = "correspondsToSegment";
        }

        public OperationsResponseCorrespondsToSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsResponseCorrespondsToSegmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsResponseCorrespondsToSegmentRelationship);
        }

        public bool Equals(OperationsResponseCorrespondsToSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsResponseCorrespondsToSegmentRelationship? left, OperationsResponseCorrespondsToSegmentRelationship? right)
        {
            return EqualityComparer<OperationsResponseCorrespondsToSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsResponseCorrespondsToSegmentRelationship? left, OperationsResponseCorrespondsToSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsResponseCorrespondsToSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}