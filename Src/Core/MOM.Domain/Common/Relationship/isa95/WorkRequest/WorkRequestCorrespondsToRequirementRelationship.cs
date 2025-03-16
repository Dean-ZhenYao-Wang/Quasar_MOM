namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestCorrespondsToRequirementRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement>, IEquatable<WorkRequestCorrespondsToRequirementRelationship>
    {
        public WorkRequestCorrespondsToRequirementRelationship()
        {
            Name = "correspondsToRequirement";
        }

        public WorkRequestCorrespondsToRequirementRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRequestCorrespondsToRequirementRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRequestCorrespondsToRequirementRelationship);
        }

        public bool Equals(WorkRequestCorrespondsToRequirementRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRequestCorrespondsToRequirementRelationship? left, WorkRequestCorrespondsToRequirementRelationship? right)
        {
            return EqualityComparer<WorkRequestCorrespondsToRequirementRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRequestCorrespondsToRequirementRelationship? left, WorkRequestCorrespondsToRequirementRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRequestCorrespondsToRequirementRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}