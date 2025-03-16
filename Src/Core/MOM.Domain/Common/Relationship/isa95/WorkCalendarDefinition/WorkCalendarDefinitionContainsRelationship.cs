namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition
{
    public class WorkCalendarDefinitionContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry>, IEquatable<WorkCalendarDefinitionContainsRelationship>
    {
        public WorkCalendarDefinitionContainsRelationship()
        {
            Name = "contains";
        }

        public WorkCalendarDefinitionContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinition source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionEntry target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinitionContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionContainsRelationship);
        }

        public bool Equals(WorkCalendarDefinitionContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinitionContainsRelationship? left, WorkCalendarDefinitionContainsRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinitionContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionContainsRelationship? left, WorkCalendarDefinitionContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinitionContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}