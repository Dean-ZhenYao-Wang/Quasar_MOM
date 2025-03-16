namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<SegmentResponseCorrespondsToRequirementRelationship>
    {
        public SegmentResponseCorrespondsToRequirementRelationship()
        {
            Name = "correspondsToRequirement";
        }

        public SegmentResponseCorrespondsToRequirementRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseCorrespondsToRequirementRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseCorrespondsToRequirementRelationship);
        }

        public bool Equals(SegmentResponseCorrespondsToRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseCorrespondsToRequirementRelationship? left, SegmentResponseCorrespondsToRequirementRelationship? right)
        {
            return EqualityComparer<SegmentResponseCorrespondsToRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseCorrespondsToRequirementRelationship? left, SegmentResponseCorrespondsToRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseCorrespondsToRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}