namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement>, IEquatable<JobOrderContainsEquipmentRelationship>
    {
        public JobOrderContainsEquipmentRelationship()
        {
            Name = "containsEquipment";
        }

        public JobOrderContainsEquipmentRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.JobOrder source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public JobOrderContainsEquipmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderContainsEquipmentRelationship);
        }

        public bool Equals(JobOrderContainsEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(JobOrderContainsEquipmentRelationship? left, JobOrderContainsEquipmentRelationship? right)
        {
            return EqualityComparer<JobOrderContainsEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderContainsEquipmentRelationship? left, JobOrderContainsEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as JobOrderContainsEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}