namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition
{
    public class WorkCalendarDefinitionHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionProperty>, IEquatable<WorkCalendarDefinitionHasPropertiesOfRelationship>
    {
        public WorkCalendarDefinitionHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkCalendarDefinitionHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinition source, Domain.isa95.CommonObjectModels.Part4.WorkCalendar.WorkCalendarDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCalendarDefinitionHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCalendarDefinitionHasPropertiesOfRelationship);
        }

        public bool Equals(WorkCalendarDefinitionHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCalendarDefinitionHasPropertiesOfRelationship? left, WorkCalendarDefinitionHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkCalendarDefinitionHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCalendarDefinitionHasPropertiesOfRelationship? left, WorkCalendarDefinitionHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCalendarDefinitionHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}