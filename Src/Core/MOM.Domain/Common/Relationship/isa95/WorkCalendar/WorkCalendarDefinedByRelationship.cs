namespace MOM.Domain.Common.Relationship.isa95.WorkCalendar
{
    public class WorkCalendarDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinition>, IEquatable<WorkCalendarDefinedByRelationship>
    {
        public WorkCalendarDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public WorkCalendarDefinedByRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendar source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinedByRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinedByRelationship);
        }

        public bool Equals(WorkCalendarDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinedByRelationship? left, WorkCalendarDefinedByRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinedByRelationship? left, WorkCalendarDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}