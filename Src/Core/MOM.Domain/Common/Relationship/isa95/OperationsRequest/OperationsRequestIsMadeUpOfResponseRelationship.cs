namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestIsMadeUpOfResponseRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse>, IEquatable<OperationsRequestIsMadeUpOfResponseRelationship>
    {
        public OperationsRequestIsMadeUpOfResponseRelationship()
        {
            Name = "isMadeUpOfResponse";
        }

        public OperationsRequestIsMadeUpOfResponseRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRequestIsMadeUpOfResponseRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRequestIsMadeUpOfResponseRelationship);
        }

        public bool Equals(OperationsRequestIsMadeUpOfResponseRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRequestIsMadeUpOfResponseRelationship? left, OperationsRequestIsMadeUpOfResponseRelationship? right)
        {
            return EqualityComparer<OperationsRequestIsMadeUpOfResponseRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRequestIsMadeUpOfResponseRelationship? left, OperationsRequestIsMadeUpOfResponseRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRequestIsMadeUpOfResponseRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}