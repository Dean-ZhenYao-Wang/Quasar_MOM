namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseCorrespondsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest>, IEquatable<WorkResponseCorrespondsToRelationship>
    {
        public WorkResponseCorrespondsToRelationship()
        {
            Name = "correspondsTo";
        }

        public WorkResponseCorrespondsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse source, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkResponseCorrespondsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkResponseCorrespondsToRelationship);
        }

        public bool Equals(WorkResponseCorrespondsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkResponseCorrespondsToRelationship? left, WorkResponseCorrespondsToRelationship? right)
        {
            return EqualityComparer<WorkResponseCorrespondsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkResponseCorrespondsToRelationship? left, WorkResponseCorrespondsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkResponseCorrespondsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}