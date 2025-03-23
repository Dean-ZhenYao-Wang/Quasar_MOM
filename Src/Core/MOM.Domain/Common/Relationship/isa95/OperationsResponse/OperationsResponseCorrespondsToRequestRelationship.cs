namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToRequestRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest>, IEquatable<OperationsResponseCorrespondsToRequestRelationship>
    {
        public OperationsResponseCorrespondsToRequestRelationship()
        {
            Name = "correspondsToRequest";
        }

        public OperationsResponseCorrespondsToRequestRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsResponseCorrespondsToRequestRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsResponseCorrespondsToRequestRelationship);
        }

        public bool Equals(OperationsResponseCorrespondsToRequestRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsResponseCorrespondsToRequestRelationship? left, OperationsResponseCorrespondsToRequestRelationship? right)
        {
            return EqualityComparer<OperationsResponseCorrespondsToRequestRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsResponseCorrespondsToRequestRelationship? left, OperationsResponseCorrespondsToRequestRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsResponseCorrespondsToRequestRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}