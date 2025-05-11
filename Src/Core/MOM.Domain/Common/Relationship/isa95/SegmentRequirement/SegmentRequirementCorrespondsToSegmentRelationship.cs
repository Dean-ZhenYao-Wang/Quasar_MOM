namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementCorrespondsToSegmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>, IEquatable<SegmentRequirementCorrespondsToSegmentRelationship>
    {
        public SegmentRequirementCorrespondsToSegmentRelationship()
        {
            Name = "correspondsToSegment";
        }

        public SegmentRequirementCorrespondsToSegmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementCorrespondsToSegmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementCorrespondsToSegmentRelationship);
        }

        public bool Equals(SegmentRequirementCorrespondsToSegmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementCorrespondsToSegmentRelationship? left, SegmentRequirementCorrespondsToSegmentRelationship? right)
        {
            return EqualityComparer<SegmentRequirementCorrespondsToSegmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementCorrespondsToSegmentRelationship? left, SegmentRequirementCorrespondsToSegmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementCorrespondsToSegmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}