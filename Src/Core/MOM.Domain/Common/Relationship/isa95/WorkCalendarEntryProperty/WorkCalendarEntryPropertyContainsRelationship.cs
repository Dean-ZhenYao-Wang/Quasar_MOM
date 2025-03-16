namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntryProperty
{
    public class WorkCalendarEntryPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty>, IEquatable<WorkCalendarEntryPropertyContainsRelationship>
    {
        public WorkCalendarEntryPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkCalendarEntryPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarEntryPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntryPropertyContainsRelationship);
        }

        public bool Equals(WorkCalendarEntryPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarEntryPropertyContainsRelationship? left, WorkCalendarEntryPropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkCalendarEntryPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntryPropertyContainsRelationship? left, WorkCalendarEntryPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarEntryPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}