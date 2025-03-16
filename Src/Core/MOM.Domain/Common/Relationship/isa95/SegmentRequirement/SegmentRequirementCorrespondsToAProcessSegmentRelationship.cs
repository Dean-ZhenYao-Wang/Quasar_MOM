namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementCorrespondsToAProcessSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>, IEquatable<SegmentRequirementCorrespondsToAProcessSegmentRelationship>
    {
        public SegmentRequirementCorrespondsToAProcessSegmentRelationship()
        {
            Name = "correspondsToAProcessSegment";
        }

        public SegmentRequirementCorrespondsToAProcessSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementCorrespondsToAProcessSegmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementCorrespondsToAProcessSegmentRelationship);
        }

        public bool Equals(SegmentRequirementCorrespondsToAProcessSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementCorrespondsToAProcessSegmentRelationship? left, SegmentRequirementCorrespondsToAProcessSegmentRelationship? right)
        {
            return EqualityComparer<SegmentRequirementCorrespondsToAProcessSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementCorrespondsToAProcessSegmentRelationship? left, SegmentRequirementCorrespondsToAProcessSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementCorrespondsToAProcessSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}