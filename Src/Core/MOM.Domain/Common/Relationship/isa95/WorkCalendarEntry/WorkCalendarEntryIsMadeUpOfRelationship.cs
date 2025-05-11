namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntry
{
    public class WorkCalendarEntryIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry>, IEquatable<WorkCalendarEntryIsMadeUpOfRelationship>
    {
        public WorkCalendarEntryIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public WorkCalendarEntryIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarEntryIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntryIsMadeUpOfRelationship);
        }

        public bool Equals(WorkCalendarEntryIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarEntryIsMadeUpOfRelationship? left, WorkCalendarEntryIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<WorkCalendarEntryIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntryIsMadeUpOfRelationship? left, WorkCalendarEntryIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarEntryIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}