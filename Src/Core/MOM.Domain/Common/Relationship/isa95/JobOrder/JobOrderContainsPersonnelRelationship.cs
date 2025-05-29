namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder,Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement>, IEquatable<JobOrderContainsPersonnelRelationship>
    {
        public JobOrderContainsPersonnelRelationship()
        {
            Name = "containsPersonnel";
        }

        public JobOrderContainsPersonnelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderContainsPersonnelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderContainsPersonnelRelationship);
        }

        public bool Equals(JobOrderContainsPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderContainsPersonnelRelationship? left, JobOrderContainsPersonnelRelationship? right)
        {
            return EqualityComparer<JobOrderContainsPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderContainsPersonnelRelationship? left, JobOrderContainsPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderContainsPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}