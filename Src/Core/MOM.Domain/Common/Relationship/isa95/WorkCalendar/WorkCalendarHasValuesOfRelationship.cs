namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty>, IEquatable<WorkCalendarHasValuesOfRelationship>
    {
        public WorkCalendarHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public WorkCalendarHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendar source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarHasValuesOfRelationship);
        }

        public bool Equals(WorkCalendarHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarHasValuesOfRelationship? left, WorkCalendarHasValuesOfRelationship? right)
        {
            return EqualityComparer<WorkCalendarHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarHasValuesOfRelationship? left, WorkCalendarHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}