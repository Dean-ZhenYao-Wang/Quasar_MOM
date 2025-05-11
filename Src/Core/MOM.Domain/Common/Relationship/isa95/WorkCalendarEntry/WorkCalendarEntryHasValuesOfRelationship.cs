namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry
{
    public class WorkCalendarEntryHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty>, IEquatable<WorkCalendarEntryHasValuesOfRelationship>
    {
        public WorkCalendarEntryHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public WorkCalendarEntryHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarEntryHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntryHasValuesOfRelationship);
        }

        public bool Equals(WorkCalendarEntryHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarEntryHasValuesOfRelationship? left, WorkCalendarEntryHasValuesOfRelationship? right)
        {
            return EqualityComparer<WorkCalendarEntryHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntryHasValuesOfRelationship? left, WorkCalendarEntryHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarEntryHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}