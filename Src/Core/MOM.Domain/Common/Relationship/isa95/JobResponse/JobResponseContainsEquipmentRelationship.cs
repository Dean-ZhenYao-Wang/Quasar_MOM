namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual>, IEquatable<JobResponseContainsEquipmentRelationship>
    {
        public JobResponseContainsEquipmentRelationship()
        {
            Name = "containsEquipment";
        }

        public JobResponseContainsEquipmentRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.JobResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobResponseContainsEquipmentRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseContainsEquipmentRelationship);
        }

        public bool Equals(JobResponseContainsEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobResponseContainsEquipmentRelationship? left, JobResponseContainsEquipmentRelationship? right)
        {
            return EqualityComparer<JobResponseContainsEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseContainsEquipmentRelationship? left, JobResponseContainsEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobResponseContainsEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}