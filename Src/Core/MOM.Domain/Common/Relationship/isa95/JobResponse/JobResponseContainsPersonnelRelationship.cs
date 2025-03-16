namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual>, IEquatable<JobResponseContainsPersonnelRelationship>
    {
        public JobResponseContainsPersonnelRelationship()
        {
            Name = "containsPersonnel";
        }

        public JobResponseContainsPersonnelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseContainsPersonnelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseContainsPersonnelRelationship);
        }

        public bool Equals(JobResponseContainsPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseContainsPersonnelRelationship? left, JobResponseContainsPersonnelRelationship? right)
        {
            return EqualityComparer<JobResponseContainsPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseContainsPersonnelRelationship? left, JobResponseContainsPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseContainsPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}