namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntry
{
    public class WorkCalendarDefinitionEntryIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry>, IEquatable<WorkCalendarDefinitionEntryIsMadeUpOfRelationship>
    {
        public WorkCalendarDefinitionEntryIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public WorkCalendarDefinitionEntryIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinitionEntryIsMadeUpOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionEntryIsMadeUpOfRelationship);
        }

        public bool Equals(WorkCalendarDefinitionEntryIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinitionEntryIsMadeUpOfRelationship? left, WorkCalendarDefinitionEntryIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinitionEntryIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionEntryIsMadeUpOfRelationship? left, WorkCalendarDefinitionEntryIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinitionEntryIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}