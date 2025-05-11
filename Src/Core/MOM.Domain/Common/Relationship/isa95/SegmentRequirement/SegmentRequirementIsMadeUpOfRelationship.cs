namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<SegmentRequirementIsMadeUpOfRelationship>
    {
        public SegmentRequirementIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public SegmentRequirementIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementIsMadeUpOfRelationship);
        }

        public bool Equals(SegmentRequirementIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementIsMadeUpOfRelationship? left, SegmentRequirementIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<SegmentRequirementIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementIsMadeUpOfRelationship? left, SegmentRequirementIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}