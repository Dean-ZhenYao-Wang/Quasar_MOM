namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry
{
    public class WorkCalendarEntryMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry>, IEquatable<WorkCalendarEntryMapsToRelationship>
    {
        public WorkCalendarEntryMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public WorkCalendarEntryMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarEntryMapsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntryMapsToRelationship);
        }

        public bool Equals(WorkCalendarEntryMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarEntryMapsToRelationship? left, WorkCalendarEntryMapsToRelationship? right)
        {
            return EqualityComparer<WorkCalendarEntryMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntryMapsToRelationship? left, WorkCalendarEntryMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarEntryMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}