namespace MOM.Domain.Common.Relationship.isa95.OperationsRequest
{
    public class OperationsRequestCorrespondsToSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<OperationsRequestCorrespondsToSegmentRelationship>
    {
        public OperationsRequestCorrespondsToSegmentRelationship()
        {
            Name = "correspondsToSegment";
        }

        public OperationsRequestCorrespondsToSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRequestCorrespondsToSegmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRequestCorrespondsToSegmentRelationship);
        }

        public bool Equals(OperationsRequestCorrespondsToSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRequestCorrespondsToSegmentRelationship? left, OperationsRequestCorrespondsToSegmentRelationship? right)
        {
            return EqualityComparer<OperationsRequestCorrespondsToSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRequestCorrespondsToSegmentRelationship? left, OperationsRequestCorrespondsToSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRequestCorrespondsToSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}