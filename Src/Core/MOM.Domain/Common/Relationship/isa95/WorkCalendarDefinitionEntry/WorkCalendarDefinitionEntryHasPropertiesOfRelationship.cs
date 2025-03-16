namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntry
{
    public class WorkCalendarDefinitionEntryHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty>, IEquatable<WorkCalendarDefinitionEntryHasPropertiesOfRelationship>
    {
        public WorkCalendarDefinitionEntryHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkCalendarDefinitionEntryHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinitionEntryHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionEntryHasPropertiesOfRelationship);
        }

        public bool Equals(WorkCalendarDefinitionEntryHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinitionEntryHasPropertiesOfRelationship? left, WorkCalendarDefinitionEntryHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinitionEntryHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionEntryHasPropertiesOfRelationship? left, WorkCalendarDefinitionEntryHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinitionEntryHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}