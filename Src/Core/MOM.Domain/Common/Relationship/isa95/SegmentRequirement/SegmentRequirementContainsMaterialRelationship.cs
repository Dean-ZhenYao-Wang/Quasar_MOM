namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>, IEquatable<SegmentRequirementContainsMaterialRelationship>
    {
        public SegmentRequirementContainsMaterialRelationship()
        {
            Name = "containsMaterial";
        }

        public SegmentRequirementContainsMaterialRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementContainsMaterialRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementContainsMaterialRelationship);
        }

        public bool Equals(SegmentRequirementContainsMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementContainsMaterialRelationship? left, SegmentRequirementContainsMaterialRelationship? right)
        {
            return EqualityComparer<SegmentRequirementContainsMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementContainsMaterialRelationship? left, SegmentRequirementContainsMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementContainsMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}