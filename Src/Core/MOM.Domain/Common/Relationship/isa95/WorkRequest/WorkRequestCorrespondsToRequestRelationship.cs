namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestCorrespondsToRequestRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest>, IEquatable<WorkRequestCorrespondsToRequestRelationship>
    {
        public WorkRequestCorrespondsToRequestRelationship()
        {
            Name = "correspondsToRequest";
        }

        public WorkRequestCorrespondsToRequestRelationship(Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRequestCorrespondsToRequestRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRequestCorrespondsToRequestRelationship);
        }

        public bool Equals(WorkRequestCorrespondsToRequestRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRequestCorrespondsToRequestRelationship? left, WorkRequestCorrespondsToRequestRelationship? right)
        {
            return EqualityComparer<WorkRequestCorrespondsToRequestRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRequestCorrespondsToRequestRelationship? left, WorkRequestCorrespondsToRequestRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRequestCorrespondsToRequestRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}