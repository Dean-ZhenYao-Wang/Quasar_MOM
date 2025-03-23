namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinitionEntryProperty
{
    public class WorkCalendarDefinitionEntryPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty>, IEquatable<WorkCalendarDefinitionEntryPropertyContainsRelationship>
    {
        public WorkCalendarDefinitionEntryPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkCalendarDefinitionEntryPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntryProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinitionEntryPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionEntryPropertyContainsRelationship);
        }

        public bool Equals(WorkCalendarDefinitionEntryPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinitionEntryPropertyContainsRelationship? left, WorkCalendarDefinitionEntryPropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinitionEntryPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionEntryPropertyContainsRelationship? left, WorkCalendarDefinitionEntryPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinitionEntryPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}