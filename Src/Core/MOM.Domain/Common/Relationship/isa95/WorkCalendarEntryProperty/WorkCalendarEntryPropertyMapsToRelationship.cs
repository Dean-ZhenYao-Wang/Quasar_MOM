namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarEntryProperty
{
    public class WorkCalendarEntryPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty>, IEquatable<WorkCalendarEntryPropertyMapsToRelationship>
    {
        public WorkCalendarEntryPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public WorkCalendarEntryPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntryProperty source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarEntryPropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarEntryPropertyMapsToRelationship);
        }

        public bool Equals(WorkCalendarEntryPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarEntryPropertyMapsToRelationship? left, WorkCalendarEntryPropertyMapsToRelationship? right)
        {
            return EqualityComparer<WorkCalendarEntryPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarEntryPropertyMapsToRelationship? left, WorkCalendarEntryPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarEntryPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}