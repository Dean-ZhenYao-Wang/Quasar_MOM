namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseIsMadeUpOfResponseRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse>, IEquatable<WorkResponseIsMadeUpOfResponseRelationship>
    {
        public WorkResponseIsMadeUpOfResponseRelationship()
        {
            Name = "isMadeUpOfResponse";
        }

        public WorkResponseIsMadeUpOfResponseRelationship(Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse source, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkResponseIsMadeUpOfResponseRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkResponseIsMadeUpOfResponseRelationship);
        }

        public bool Equals(WorkResponseIsMadeUpOfResponseRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkResponseIsMadeUpOfResponseRelationship? left, WorkResponseIsMadeUpOfResponseRelationship? right)
        {
            return EqualityComparer<WorkResponseIsMadeUpOfResponseRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkResponseIsMadeUpOfResponseRelationship? left, WorkResponseIsMadeUpOfResponseRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkResponseIsMadeUpOfResponseRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}