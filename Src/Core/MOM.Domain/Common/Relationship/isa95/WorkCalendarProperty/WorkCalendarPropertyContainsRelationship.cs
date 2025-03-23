namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarProperty
{
    public class WorkCalendarPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty>, IEquatable<WorkCalendarPropertyContainsRelationship>
    {
        public WorkCalendarPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkCalendarPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarPropertyContainsRelationship);
        }

        public bool Equals(WorkCalendarPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarPropertyContainsRelationship? left, WorkCalendarPropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkCalendarPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarPropertyContainsRelationship? left, WorkCalendarPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}