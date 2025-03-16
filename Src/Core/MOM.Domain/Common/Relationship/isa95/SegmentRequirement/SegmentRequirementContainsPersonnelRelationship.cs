namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement>, IEquatable<SegmentRequirementContainsPersonnelRelationship>
    {
        public SegmentRequirementContainsPersonnelRelationship()
        {
            Name = "containsPersonnel";
        }

        public SegmentRequirementContainsPersonnelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementContainsPersonnelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementContainsPersonnelRelationship);
        }

        public bool Equals(SegmentRequirementContainsPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementContainsPersonnelRelationship? left, SegmentRequirementContainsPersonnelRelationship? right)
        {
            return EqualityComparer<SegmentRequirementContainsPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementContainsPersonnelRelationship? left, SegmentRequirementContainsPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementContainsPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}