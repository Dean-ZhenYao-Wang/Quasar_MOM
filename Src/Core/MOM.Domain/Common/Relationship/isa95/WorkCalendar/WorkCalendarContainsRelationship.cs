namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry>, IEquatable<WorkCalendarContainsRelationship>
    {
        public WorkCalendarContainsRelationship()
        {
            Name = "contains";
        }

        public WorkCalendarContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendar source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarContainsRelationship);
        }

        public bool Equals(WorkCalendarContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarContainsRelationship? left, WorkCalendarContainsRelationship? right)
        {
            return EqualityComparer<WorkCalendarContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarContainsRelationship? left, WorkCalendarContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}