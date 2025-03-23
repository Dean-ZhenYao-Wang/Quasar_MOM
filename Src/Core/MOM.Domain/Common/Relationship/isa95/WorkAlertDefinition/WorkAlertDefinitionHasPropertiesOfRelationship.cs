namespace MOM.Domain.Common.Relationship.isa95.WorkAlertDefinition
{
    public class WorkAlertDefinitionHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty>, IEquatable<WorkAlertDefinitionHasPropertiesOfRelationship>
    {
        public WorkAlertDefinitionHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public WorkAlertDefinitionHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinition source, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertDefinitionHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertDefinitionHasPropertiesOfRelationship);
        }

        public bool Equals(WorkAlertDefinitionHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertDefinitionHasPropertiesOfRelationship? left, WorkAlertDefinitionHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkAlertDefinitionHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertDefinitionHasPropertiesOfRelationship? left, WorkAlertDefinitionHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertDefinitionHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}